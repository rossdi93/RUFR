using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using System;
using System.Linq;
using RUFR.Api.Service.Interfaces;


namespace RUFR.Api.Web.Controllers
{
    [Route("api/MemberPriority")]
    [ApiController]
    public class MemberPriorityController : ControllerBase
    {
        private readonly IMemberPriorityService _memberPriorityService;

        public MemberPriorityController(IMemberPriorityService memberPriorityService)
        {
            _memberPriorityService = memberPriorityService;
        }

        /// <summary>
        /// Получение всех сущностей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_memberPriorityService.Select().ToList());
        }

        /// <summary>
        /// Получение по id конктретной сущности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_memberPriorityService.GetById(id));
        }

        /// <summary>
        /// Добавление новой сущности
        /// </summary>
        /// <param name="memberPriority"></param>
        /// <returns></returns>
        [HttpPost("New")]
        public IActionResult New([FromBody] MemberPriorityModel memberPriority)
        {
            MemberPriorityModel newMemberPriority = _memberPriorityService.Create(memberPriority);

            return Ok(newMemberPriority);
        }

        /// <summary>
        /// Обновление сущетсвующего сущности
        /// </summary>
        /// <param name="memberPriority"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        public IActionResult Update([FromBody] MemberPriorityModel memberPriority)
        {
            if (_memberPriorityService.GetById(memberPriority.Id) == null)
            {
                return NotFound(memberPriority);
            }

            try
            {
                MemberPriorityModel oldMemberPriority = _memberPriorityService.GetById(memberPriority.Id);

                _memberPriorityService.Update(oldMemberPriority);

                return Ok(oldMemberPriority);

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
                var memberPriority = _memberPriorityService.GetById(id);
                if (memberPriority != null)
                {
                    _memberPriorityService.Delete(id);
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
