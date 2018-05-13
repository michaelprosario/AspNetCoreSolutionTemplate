using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Core.Entities;
using App.Core.Interfaces;
using App.Web.ApiModels;
using App.Web.Filters;
using App.Core.Requests;
using App.Core.Responses;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Api
{
    [Route("api/[controller]")]
    [ValidateModel]
    public class TasksController : Controller
    {
        private readonly IRepository<TaskItem> _tasksRepository;
        private readonly App.Core.Services.TasksService _tasksService;

        public TasksController(IRepository<TaskItem> tasksRepository)
        {
            _tasksRepository = tasksRepository;
            _tasksService = new Core.Services.TasksService(_tasksRepository);
        }

        [HttpGet]
        public IActionResult List()
        {
            var records = _tasksService.GetAll();
            return Ok(records);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var request = new GetTaskRequest();
            request.Id = id;

            var record = _tasksService.Get(request);
            return Ok(record);
        }

        [HttpPost]
        public IActionResult Post([FromBody] App.Core.Requests.CreateTaskRequest request)
        {
            var response = _tasksService.Add(request);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var request = new DeleteTaskRequest(){ Id = id };
            var response = _tasksService.Delete(request);
            return Ok(response);
        }
    }
}
