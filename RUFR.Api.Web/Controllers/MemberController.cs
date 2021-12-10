using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using System;
using System.Linq;
using RUFR.Api.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RUFR.Api.Web.Controllers
{
    [Route("api/Member")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        /// <summary>
        /// Получение всех сущностей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var members = _memberService.Select()
                .Include(p => p.ProjectModels)
                .Include(p => p.PriorityDirectionModels)
                .Include(p => p.TypesOfCooperationModels).ToArray();
            return Ok(members);
        }

        /// <summary>
        /// Получение по id конктретной сущности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var member = _memberService.Select().Where(m => m.Id == id)
                .Include(p => p.ProjectModels)
                .Include(p => p.PriorityDirectionModels)
                .Include(p => p.TypesOfCooperationModels);
            return Ok(member);
        }

        /// <summary>
        /// Добавление новой сущности
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        [HttpPost("New")]
        public IActionResult New([FromBody] MemberModel member)
        {
            MemberModel newMember = _memberService.Create(member);

            return Ok(newMember);
        }

        /// <summary>
        /// Обновление сущетсвующего сущности
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        public IActionResult Update([FromBody] MemberModel member)
        {
            if (_memberService.GetById(member.Id) == null)
            {
                return NotFound(member);
            }

            try
            {
                MemberModel oldMember = _memberService.GetById(member.Id);
                oldMember.Countrys = member.Countrys;
                oldMember.Date = member.Date;
                oldMember.Name = member.Name;
                oldMember.Logo = member.Logo;

                if (oldMember.PriorityDirectionModels != member.PriorityDirectionModels)
                {
                    oldMember.PriorityDirectionModels.Clear();
                    foreach (var pd in member.PriorityDirectionModels)
                    {
                        oldMember.PriorityDirectionModels.Add(pd);
                    }
                }

                if (oldMember.TypesOfCooperationModels != member.TypesOfCooperationModels)
                {
                    oldMember.PriorityDirectionModels.Clear();
                    foreach (var tc in member.TypesOfCooperationModels)
                    {
                        oldMember.TypesOfCooperationModels.Add(tc);
                    }
                }

                _memberService.Update(oldMember);

                return Ok(oldMember);

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
            var member = _memberService.GetById(id);
            if (!member.IsDelete)
            {
                member.IsDelete = true;
                try
                {
                    _memberService.Update(member);
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

