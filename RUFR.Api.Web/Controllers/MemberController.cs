using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using System;
using System.Linq;
using RUFR.Api.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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
                .Include(p => p.MemberPriorityModels)
                    .Include(p => p.ProjectMemberModels)
                    .Include(p => p.MemberTypesOfCooperationModels).ToArray();
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
            var member = _memberService.Select()
                .Include(p => p.MemberPriorityModels)
                    .Include(p => p.ProjectMemberModels)
                    .Include(p => p.MemberTypesOfCooperationModels).FirstOrDefault(m => m.Id == id);
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
            return Ok(_memberService.Create(member));
        }

        /// <summary>
        /// Обновление сущетсвующего сущности
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        public IActionResult Update([FromBody] MemberModel member)
        {
            try
            {
                var oldMember = _memberService.Select()
                .Include(p => p.ProjectMemberModels)
                    .ThenInclude(p => p.ProjectModel)
                .Include(p => p.MemberPriorityModels)
                    .ThenInclude(p => p.PriorityDirectionModel)
                .Include(p => p.MemberTypesOfCooperationModels)
                    .ThenInclude(p => p.TypesOfCooperationModel).FirstOrDefault(m => m.Id == member.Id);

                oldMember.Countrys = member.Countrys;
                oldMember.Date = member.Date;
                oldMember.Name = member.Name;
                oldMember.Logo = member.Logo;
                oldMember.Lang = member.Lang;

                _memberService.Update(oldMember);

                return Ok(member);
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

