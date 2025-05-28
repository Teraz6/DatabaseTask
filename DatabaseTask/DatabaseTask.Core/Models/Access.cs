using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    public class Access
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<Position>? Addresses { get; set; }
    }
}
