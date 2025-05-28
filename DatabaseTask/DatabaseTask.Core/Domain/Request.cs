using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    class Request
    {
        public int Id { get; set; }
        public int WorkTopicId { get; set; }
        [ForeignKey(nameof(WorkTopicId))]
        public WorkTopic WorkTopic { get; set; }

        public int CreatorEmployeeId { get; set; }
        [ForeignKey(nameof(CreatorEmployeeId))]
        public Employee Employee { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ReviewedDate { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
