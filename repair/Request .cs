using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repair
{
    public class Request
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public Request(int id, string description, string status)
        {
            Id = id;
            Description = description;
            Status = status;
        }
        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
        }
    }
}
