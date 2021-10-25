﻿using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using System;
using System.Linq;
using RUFR.Api.Service.Interfaces;

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
            return Ok(_memberService.Select().ToList());
        }

        /// <summary>
        /// Получение по id конктретной сущности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_memberService.GetById(id));
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

            if (newMember.PriorityDirectionModels != member.PriorityDirectionModels)
            {
                foreach (var pd in member.PriorityDirectionModels)
                {
                    newMember.PriorityDirectionModels.Add(pd);
                }
                _memberService.Update(newMember);
            }

            if (newMember.TypesOfCooperationModels != member.TypesOfCooperationModels)
            {
                foreach (var tc in member.TypesOfCooperationModels)
                {
                    newMember.TypesOfCooperationModels.Add(tc);
                }
                _memberService.Update(newMember);
            }

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

