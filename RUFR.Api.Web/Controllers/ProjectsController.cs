using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using System;
using System.Linq;
using RUFR.Api.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RUFR.Api.Web.Controllers
{
    [Route("api/Projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        /// <summary>
        /// Получение всех сущностей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var projects = _projectService.Select()
              .Include(p => p.Priorities).ToArray();
            return Ok(projects);
        }

        /// <summary>
        /// Получение по id конктретной сущности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var project = _projectService.Select().Where(p => p.Id == id)
             .Include(p => p.Priorities);
            return Ok(project);
        }

        /// <summary>
        /// Добавление нового сущности
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        [HttpPost("New")]
        public IActionResult New([FromBody] ProjectModel project)
        {
            ProjectModel newProject = _projectService.Create(project);

            return Ok(newProject);
        }

        /// <summary>
        /// Обновление сущетсвующего сущности
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        public IActionResult Update([FromBody] ProjectModel project)
        {
            if (_projectService.GetById(project.Id) == null)
            {
                return NotFound(project);
            }

            try
            {
                ProjectModel oldProject = _projectService.GetById(project.Id);
                oldProject.Countrys = project.Countrys;
                oldProject.Logo = project.Logo;
                oldProject.Name = project.Name;
                oldProject.ProjectStage = project.ProjectStage;
                oldProject.TypeOfProject = project.TypeOfProject;
                oldProject.Content = project.Content;
                oldProject.Lang = project.Lang;
                oldProject.Description = project.Description;

                if (oldProject.Priorities != project.Priorities)
                {
                    oldProject.Priorities.Clear();
                    foreach (var pd in project.Priorities)
                    {
                        oldProject.Priorities.Add(pd);
                    }
                }

                _projectService.Update(oldProject);

                return Ok(oldProject);

            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Удаление сущности по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var project = _projectService.GetById(id);
            if (!project.IsDelete)
            {
                project.IsDelete = true;
                try
                {
                    _projectService.Update(project);
                    return Ok();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                return Ok(false);
            }
        }
    }
}
