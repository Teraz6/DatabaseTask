using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public required Employee Employee { get; set; }
        public required int Wage {  get; set; }
        public DateTime StartDate { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
