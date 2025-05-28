using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    public class WorkTopic
    {
        public int Id { get; set; }
        public required string Description { get; set; }

        public ICollection<Hint> Hint { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}
