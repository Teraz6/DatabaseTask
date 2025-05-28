using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    class JobHistory
    {
        public int Id { get; set; }

        public int PositionId { get; set; }
        [ForeignKey(nameof(PositionId))]
        public required Position Position { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public required Employee Employee { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<Position>? Positions { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
