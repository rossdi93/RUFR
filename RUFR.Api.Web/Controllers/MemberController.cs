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
                .Include(p => p.MemberTypesOfCooperationModels)
                .Include(s => s.StatisticalInformationModels)
                .Include(u => u.UserMemberModels).ToArray();
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
                .Include(m => m.MemberTypesOfCooperationModels)
                .Include(s => s.StatisticalInformationModels)
                .Include(u => u.UserMemberModels).FirstOrDefault(m => m.Id == id);

            if (member != null)
            {
                return Ok(member);
            }
            else
            {
                return NotFound(member);
            }
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
                    .Include(p => p.MemberPriorityModels)
                    .Include(p => p.ProjectMemberModels)
                    .Include(p => p.MemberTypesOfCooperationModels)
                    .Include(s => s.StatisticalInformationModels)
                    .Include(u => u.UserMemberModels).FirstOrDefault(m => m.Id == member.Id);

                if (oldMember != null)
                {
                    oldMember.Countrys = member.Countrys;
                    oldMember.Date = member.Date;
                    oldMember.Name = member.Name;
                    oldMember.Logo = member.Logo;
                    oldMember.Lang = member.Lang;
                    oldMember.WebSite = member.WebSite;
                    oldMember.Content = member.Content;
                    oldMember.Description = member.Description;

                    if (!member.MemberPriorityModels.Select(mp => mp.PriorityDirectionModelId).ToArray().
                        SequenceEqual(oldMember.MemberPriorityModels.Select(mp => mp.PriorityDirectionModelId).ToArray()))
                    {
                        oldMember.MemberPriorityModels.Clear();
                        foreach (var priorityModel in member.MemberPriorityModels)
                        {
                            oldMember.MemberPriorityModels.Add(new MemberPriorityModel { MemberModelId = priorityModel.MemberModelId, 
                                PriorityDirectionModelId = priorityModel.PriorityDirectionModelId, EnrollmentDate = DateTime.Now });
                        }
                    }

                    if (!member.MemberTypesOfCooperationModels.Select(mt => mt.TypesOfCooperationModelId).ToArray().
                        SequenceEqual(oldMember.MemberTypesOfCooperationModels.Select(mt => mt.TypesOfCooperationModelId).ToArray()))
                    {
                        oldMember.MemberTypesOfCooperationModels.Clear();
                        foreach (var typesOfCooperation in member.MemberTypesOfCooperationModels)
                        {
                            oldMember.MemberTypesOfCooperationModels.Add(new MemberTypesOfCooperationModel { MemberModelId = typesOfCooperation.MemberModelId, 
                                TypesOfCooperationModelId = typesOfCooperation.TypesOfCooperationModelId, EnrollmentDate = DateTime.Now });
                        }
                    }

                    if (!member.StatisticalInformationModels.Select(mt => mt.Id).ToArray().
                        SequenceEqual(oldMember.StatisticalInformationModels.Select(mt => mt.Id).ToArray()))
                    {
                        oldMember.StatisticalInformationModels.Clear();
                        foreach (var keyValue in member.StatisticalInformationModels)
                        {
                            oldMember.StatisticalInformationModels.Add(new StatisticalInformationModel { MemberModelId = keyValue.MemberModelId, Name = keyValue.Name, 
                                Key = keyValue.Key, Value = keyValue.Value });
                        }
                    }

                    if (!member.UserMemberModels.Select(u => u.Id).ToArray().
                        SequenceEqual(oldMember.UserMemberModels.Select(u => u.Id).ToArray()))
                    {
                        oldMember.UserMemberModels.Clear();
                        foreach (var keyValue in member.UserMemberModels)
                        {
                            oldMember.UserMemberModels.Add(new UserMemberModel { MemberModelId = keyValue.MemberModelId, UserModelId = keyValue.UserModelId,
                                Position = keyValue.Position, EnrollmentDate = DateTime.Now });
                        }
                    }

                    //if (!member.ProjectMemberModels.Select(p => p.ProjectModelId).ToArray().
                    //    SequenceEqual(oldMember.ProjectMemberModels.Select(p => p.ProjectModelId).ToArray()))
                    //{
                    //    oldMember.ProjectMemberModels.Clear();
                    //    foreach (var priorityModel in member.ProjectMemberModels)
                    //    {
                    //        oldMember.ProjectMemberModels.Add(new ProjectMemberModel { MemberModelId = priorityModel.MemberModelId, ProjectModelId = priorityModel.ProjectModelId, EnrollmentDate = DateTime.Now });
                    //    }
                    //}

                    _memberService.Update(oldMember);

                    return Ok(oldMember);
                }
                else
                {
                    return NotFound(member);
                }
                

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
            var member = _memberService.Select()
                    .Include(p => p.MemberPriorityModels)
                    .Include(p => p.ProjectMemberModels)
                    .Include(p => p.MemberTypesOfCooperationModels)
                    .Include(s => s.StatisticalInformationModels)
                    .Include(u => u.UserMemberModels).FirstOrDefault(m => m.Id == id);

            if (!member.IsDelete && member != null)
            {
                try
                {
                    member.IsDelete = true;
                    member.MemberPriorityModels.Clear();
                    member.ProjectMemberModels.Clear();
                    member.MemberTypesOfCooperationModels.Clear();
                    member.StatisticalInformationModels.Clear();
                    member.UserMemberModels.Clear();
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

