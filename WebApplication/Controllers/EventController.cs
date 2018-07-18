using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
  
    [Route("api/Event")]
    public class EventController : Controller
    {
        public List<EventModel> Events { get; set; } = new List<EventModel>()
            {
                new EventModel()
        {
                    Id = 1,
                    Name = "TT",
                    Category = "Non technical",
                    Venue = "Hall"
                },
                new EventModel()
        {
                    Id = 2,
                    Name = "Quiz",
                   Category = "Technical",
                    Venue = "Base Camp"
                }
    };
        // GET: api/Events
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Events);
        }

        // GET: api/Events/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var events = Events.FirstOrDefault(e => e.Id == id);
            if (events != null)
                return Ok(events);
            else
                return NotFound();
        }

        // POST: api/Events
        [HttpPost]
        public IActionResult Post(EventModel employee)
        {
            Events.Add(employee);

            return Ok(Events);
        }

        // PUT: api/Events/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}