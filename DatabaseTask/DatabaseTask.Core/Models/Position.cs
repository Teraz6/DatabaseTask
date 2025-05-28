using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    public class Position
    {
        public int Id { get; set; }
        public int AccessId { get; set; }
        [ForeignKey(nameof(AccessId))]
        public required Access Access { get; set; }
        public string? Description { get; set; }
        public DateTime PositionCreatedDate { get; set; }
        public DateTime? PositionDisabledDate { get; set; }

        public ICollection<JobHistory> JobHistory { get; set; }
    }
}
