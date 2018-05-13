using System;
using System.Collections.Generic;
using System.Linq;
using App.Core.Responses;
using App.Core.Requests;
using App.Core.Entities;
using App.Core.Enums;
using App.Core.Interfaces;

namespace App.Core.Services{
    public class TasksService{

        private IRepository<TaskItem> _taskItemRepository;
        public TasksService(IRepository<TaskItem> taskItemRepository){
            _taskItemRepository = taskItemRepository;
        }

        public CreateTaskResponse Add(CreateTaskRequest request){
            if(request == null)
            {
                throw new ArgumentNullException();
            }

            TaskItem record = new TaskItem();
            record.Name = request.Name;
            record.IsComplete = request.IsComplete;

            _taskItemRepository.Add(record);

            CreateTaskResponse response = new CreateTaskResponse();
            response.Id = record.Id;
            return response;
        }

        public DeleteTaskResponse Delete(DeleteTaskRequest request){
            if(request == null)
            {
                throw new ArgumentNullException();
            }
            
            DeleteTaskResponse response = new DeleteTaskResponse();

            var record = _taskItemRepository.GetById(request.Id);
            if (record == null)
            {
                response.Code = ResponseCode.NotFound;
                response.Message = "Record not found.";
                return response;
            }
            
            _taskItemRepository.Delete(record);

            return response;
        }

        public GetTaskResponse Get(GetTaskRequest request){
            if(request == null)
            {
                throw new ArgumentNullException();
            }

            GetTaskResponse response = new GetTaskResponse();
            response.Record = _taskItemRepository.GetById(request.Id);

            if(response.Record == null){
                response.Code = ResponseCode.NotFound;
                response.Message = "Record not found.";
            }

            return response;
        }

        public ListTasksResponse GetAll(){
            ListTasksResponse response = new ListTasksResponse();
            response.Records = _taskItemRepository.List();
            return response;
        }

        public bool RecordExists(int id){
            var record = _taskItemRepository.GetById(id);
            return record != null;
        }
    }
}