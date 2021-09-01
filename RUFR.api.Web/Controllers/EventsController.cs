using Api.DataLayer;
using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RUFR.api.Controllers
{
    [Route("api/Events")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public EventsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/<EventController>
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(_context.EventModels.ToList());
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.EventModels.First(u => u.Id == id));
        }

        // POST api/<EventController>
        [HttpPost]
        public IActionResult Post([FromBody] EventModel events)
        {
            EventModel newEvents = _context.EventModels.Add(events).Entity;
            _context.SaveChanges();
            return Ok(newEvents);
        }

        // PUT api/<EventController>/5
        [HttpPut]
        public IActionResult Put([FromBody] EventModel events)
        {
            EventModel newEvents = _context.EventModels.Update(events).Entity;
            _context.SaveChanges();
            return Ok(newEvents);
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _context.EventModels.First(u => u.Id == id).IsDelete = true;
            _context.SaveChanges();
            if (_context.EventModels.First(u => u.Id == id).IsDelete == true)
                return Ok();
            else
                return Ok(false);
        }
    }
}
