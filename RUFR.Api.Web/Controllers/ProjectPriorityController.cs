using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using System;
using System.Linq;
using RUFR.Api.Service.Interfaces;


namespace RUFR.Api.Web.Controllers
{
    [Route("api/ProjectPriority")]
    [ApiController]
    public class ProjectPriorityController : ControllerBase
    {
        private readonly IProjectPriorityService _projectPriorityService;

        public ProjectPriorityController(IProjectPriorityService projectPriorityService)
        {
            _projectPriorityService = projectPriorityService;
        }

        /// <summary>
        /// Получение всех сущностей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_projectPriorityService.Select().ToList());
        }

        /// <summary>
        /// Получение по id конктретной сущности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_projectPriorityService.GetById(id));
        }

        /// <summary>
        /// Добавление новой сущности
        /// </summary>
        /// <param name="projectPriority"></param>
        /// <returns></returns>
        [HttpPost("New")]
        public IActionResult New([FromBody] ProjectPriorityModel projectPriority)
        {
            ProjectPriorityModel newProjectPriority = _projectPriorityService.Create(projectPriority);

            return Ok(newProjectPriority);
        }

        /// <summary>
        /// Обновление сущетсвующего сущности
        /// </summary>
        /// <param name="projectPriority"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        public IActionResult Update([FromBody] MemberPriorityModel projectPriority)
        {
            if (_projectPriorityService.GetById(projectPriority.Id) == null)
            {
                return NotFound(projectPriority);
            }

            try
            {
                return Ok(projectPriority);

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
            try
            {
                var memberPriority = _projectPriorityService.GetById(id);
                if (memberPriority != null)
                {
                    _projectPriorityService.Delete(id);
                }

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
