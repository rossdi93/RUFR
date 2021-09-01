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
    [Route("api/News")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public NewsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/<NewsController>
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(_context.NewsModels.ToList());
        }

        // GET api/<NewsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.NewsModels.First(u => u.Id == id));
        }

        // POST api/<NewsController>
        [HttpPost]
        public IActionResult Post([FromBody] NewsModel news)
        {
            NewsModel newNews = _context.NewsModels.Add(news).Entity;
            _context.SaveChanges();
            return Ok(newNews);
        }

        // PUT api/<NewsController>/5
        [HttpPut]
        public IActionResult Put([FromBody] NewsModel news)
        {
            NewsModel newsModel = _context.NewsModels.Update(news).Entity;
            _context.SaveChanges();
            return Ok(newsModel);
        }

        // DELETE api/<NewsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _context.NewsModels.First(u => u.Id == id).IsDelete = true;
            _context.SaveChanges();
            if (_context.NewsModels.First(u => u.Id == id).IsDelete == true)
                return Ok();
            else
                return Ok(false);
        }
    }
}
