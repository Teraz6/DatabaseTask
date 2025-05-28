using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    class Child
    {
        public int Id { get; set; }

        public int ParentId { get; set; }
        [ForeignKey(nameof(ParentId))]
        public Employee Parent { get; set; }

        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
