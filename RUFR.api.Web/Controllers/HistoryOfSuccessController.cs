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
    public class HistoryOfSuccessController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public HistoryOfSuccessController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/<HistoryOfSuccessController>
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(_context.HistoryOfSuccessModels.ToList());
        }

        // GET api/<HistoryOfSuccessController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.HistoryOfSuccessModels.First(u => u.Id == id));
        }

        // POST api/<HistoryOfSuccessController>
        [HttpPost]
        public IActionResult Post([FromBody] HistoryOfSuccessModel history)
        {
            HistoryOfSuccessModel newHistory = _context.HistoryOfSuccessModels.Add(history).Entity;
            _context.SaveChanges();
            return Ok(newHistory);
        }

        // PUT api/<HistoryOfSuccessController>/5
        [HttpPut]
        public IActionResult Put([FromBody] HistoryOfSuccessModel history)
        {
            HistoryOfSuccessModel newHistory = _context.HistoryOfSuccessModels.Update(history).Entity;
            _context.SaveChanges();
            return Ok(newHistory);
        }

        // DELETE api/<HistoryOfSuccessController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _context.HistoryOfSuccessModels.First(u => u.Id == id).IsDelete = true;
            _context.SaveChanges();
            if (_context.HistoryOfSuccessModels.First(u => u.Id == id).IsDelete == true)
                return Ok();
            else
                return Ok(false);
        }
    }
}
