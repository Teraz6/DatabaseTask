using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    class Address
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public required Employee Employee { get; set; }

        public required string PostalCode { get; set; }
        public required int AppartmentNr { get; set; }
        public required int BuildingNr { get; set; }
        public required string Street { get; set; }
        public required string District { get; set; }
        public required string City { get; set; }
        public required string County { get; set; }
        public required string Country { get; set; }

        public ICollection<Employee>? Employees { get; set; }
    }
}
