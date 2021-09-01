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
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public UsersController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/<UserController>
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(_context.Users.ToList());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.Users.First(u => u.Id == id));
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] UserModel user)
        {
            UserModel newUser = _context.Users.Add(user).Entity;
            _context.SaveChanges();
            return Ok(newUser);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public IActionResult Put([FromBody] UserModel user)
        {
            UserModel newUser = _context.Users.Update(user).Entity;
           _context.SaveChanges();
            return Ok(newUser);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _context.Users.First(u => u.Id == id).IsDelete = true;
            _context.SaveChanges();
            if (_context.Users.First(u => u.Id == id).IsDelete == true)
                return Ok();
            else
                return Ok(false);
        }
    }
}
