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
    [Route("api/Projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public ProjectsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/<ProjectController>
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(_context.ProjectModels.ToList());
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.ProjectModels.First(u => u.Id == id));
        }

        // POST api/<ProjectController>
        [HttpPost]
        public IActionResult Post([FromBody] ProjectModel project)
        {
            ProjectModel newProject = _context.ProjectModels.Add(project).Entity;
            _context.SaveChanges();
            return Ok(newProject);
        }

        // PUT api/<ProjectController>/5
        [HttpPut]
        public IActionResult Put([FromBody] ProjectModel project)
        {
            ProjectModel upProject = _context.ProjectModels.Update(project).Entity;
           _context.SaveChanges();
            return Ok(upProject);
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _context.ProjectModels.First(u => u.Id == id).IsDelete = true;
            _context.SaveChanges();
            if (_context.ProjectModels.First(u => u.Id == id).IsDelete == true)
                return Ok();
            else
                return Ok(false);
        }
    }
}
