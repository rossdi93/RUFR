using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using System;
using System.Linq;
using RUFR.Api.Service.Interfaces;


namespace RUFR.Api.Web.Controllers
{
    [Route("api/PriorityDirection")]
    [ApiController]
    public class PriorityDirectionController : Controller
    {
        private readonly IPriorityDirectionService _priorityDirectionService;

        public PriorityDirectionController(IPriorityDirectionService priorityDirectionService)
        {
            _priorityDirectionService = priorityDirectionService;
        }

        /// <summary>
        /// Получение всех сущностей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_priorityDirectionService.Select().ToList());
        }

        /// <summary>
        /// Получение по id конктретной сущности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_priorityDirectionService.GetById(id));
        }

        /// <summary>
        /// Добавление нового сущности
        /// </summary>
        /// <param name="pd"></param>
        /// <returns></returns>
        [HttpPost("New")]
        public IActionResult New([FromBody] PriorityDirectionModel pd)
        {
            PriorityDirectionModel newpd = _priorityDirectionService.Create(pd);

            return Ok(newpd);
        }

        /// <summary>
        /// Обновление сущетсвующего сущности
        /// </summary>
        /// <param name="pd"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        public IActionResult Update([FromBody] PriorityDirectionModel pd)
        {
            if (_priorityDirectionService.GetById(pd.Id) == null)
            {
                return NotFound(pd);
            }

            try
            {
                PriorityDirectionModel oldPd = _priorityDirectionService.GetById(pd.Id);
                oldPd.Description = pd.Description;
                oldPd.IsDelete = pd.IsDelete;
                oldPd.MemberModels = pd.MemberModels;
                oldPd.ProjectModels = pd.ProjectModels;
                oldPd.Name = pd.Name;


                _priorityDirectionService.Update(oldPd);

                return Ok(oldPd);

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
            var pd = _priorityDirectionService.GetById(id);
            if (!pd.IsDelete)
            {
                pd.IsDelete = true;
                try
                {
                    _priorityDirectionService.Update(pd);
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
