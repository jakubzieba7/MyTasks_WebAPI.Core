using System;

namespace MyTasks_WebAPI.Core.DTOs
{
    public class TaskDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public bool IsExecuted { get; set; }
        public DateTime? Term { get; set; }
        public string UserId { get; set; }
    }
}
