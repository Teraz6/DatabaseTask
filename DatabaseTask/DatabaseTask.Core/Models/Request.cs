using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    public class Request
    {
        public int Id { get; set; }
        public int WorkTopicId { get; set; }
        [ForeignKey(nameof(WorkTopicId))]
        public required WorkTopic WorkTopic { get; set; }

        public int CreatorEmployeeId { get; set; }
        [ForeignKey(nameof(CreatorEmployeeId))]
        public required Employee Employee { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ReviewedDate { get; set; }
        public string? Status { get; set; }
        public required string Description { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<WorkTopic> WorkTopics { get; set; }
    }
}
