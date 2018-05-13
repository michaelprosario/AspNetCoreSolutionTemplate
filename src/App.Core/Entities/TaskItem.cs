using App.Core.SharedKernel;

namespace App.Core.Entities
{
    public class TaskItem : BaseEntity
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}