using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class EventModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Venue { get; set; }
    }
}
