using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    class Employee
    {
        [Key]
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public int PersonalCode { get; set; }
        public int AddressId { get; set; }
        [ForeignKey(nameof(AddressId))]
        public required Address Address { get; set; }

        public int? JobHistoryId { get; set; }
        [ForeignKey(nameof(JobHistoryId))]
        public JobHistory? JobHistory { get; set; }

        public ICollection<Address>? Addresses { get; set; }

        public ICollection<JobHistory>? JobHistories { get; set; }
    }
}
