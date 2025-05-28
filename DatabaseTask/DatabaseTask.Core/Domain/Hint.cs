using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    class Hint
    {
        public int Id { get; set; }

        public int WorkTopicId { get; set; }
        [ForeignKey(nameof(WorkTopicId))]
        public required WorkTopic WorkTopic { get; set; }

        public int? CreatorId { get; set; }
        [ForeignKey(nameof(CreatorId))]
        public Employee? Employee { get; set; }

        public ICollection<Employee>? Employees { get; set; }
        public ICollection<WorkTopic> WorkTopics { get; set; }
    }
}
