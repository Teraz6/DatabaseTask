using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    class Devices
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Manufacturer { get; set; }
        public string? Type { get; set; }
        public string? SerialNumber { get; set; }
        public string? Condition { get; set; }
    }
}
