using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    class VacationList
    {
        public int Id { get; set; }
        
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public required Employee Employee { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        public int ApprovedBy { get; set; }
        [ForeignKey(nameof(ApprovedBy))]
        public required Employee Approver { get; set; }

        public DateTime DateApproved { get; set; }
        public int TotalDays { get; set; }
        public int VacationDaysUsed { get; set; }
        public int VacationDaysRemaining { get; set; }
    }
}
