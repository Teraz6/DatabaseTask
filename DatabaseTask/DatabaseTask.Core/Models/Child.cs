using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    public class Child
    {
        public int Id { get; set; }

        public int ParentId { get; set; }
        [ForeignKey(nameof(ParentId))]
        public required Employee Parent { get; set; }

        public DateTime BirthDate { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        public required ICollection<Employee> Employees { get; set; }
    }
}
