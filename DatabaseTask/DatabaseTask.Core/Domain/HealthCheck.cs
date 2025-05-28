using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    class HealthCheck
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }

        public DateTime LastCheckDate { get; set; }
        public DateTime NextCheckDate { get; set; }
        public bool IsHealthy { get; set; }
    }
}
