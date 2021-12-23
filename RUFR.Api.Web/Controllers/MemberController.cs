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
        private readonly IMemberPriorityService _memberPriorityService;
        private readonly IStatisticalInformationService _statisticalInformationService;
        private readonly IMemberTypesOfCooperationService _memberTypesOfCooperationService;
        private readonly IProjectMemberService _projectMemberService;
        private readonly IUserMemberService _userMemberService;

        public MemberController(IMemberService memberService, 
            IMemberPriorityService memberPriorityService,
            IStatisticalInformationService statisticalInformationService,
            IMemberTypesOfCooperationService memberTypesOfCooperationService,
            IProjectMemberService projectMemberService,
            IUserMemberService userMemberService)
        {
            _memberService = memberService;
            _memberPriorityService = memberPriorityService;
            _statisticalInformationService = statisticalInformationService;
            _memberTypesOfCooperationService = memberTypesOfCooperationService;
            _projectMemberService = projectMemberService;
            _userMemberService = userMemberService;
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
                    .ThenInclude(p => p.PriorityDirectionModel)
                .Include(p => p.ProjectMemberModels)
                    .ThenInclude(p => p.ProjectModel)
                .Include(p => p.MemberTypesOfCooperationModels)
                    .ThenInclude(t => t.TypesOfCooperationModel)
                .Include(s => s.StatisticalInformationModels)
                .Include(u => u.UserMemberModels).AsNoTracking().ToArray();
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
                    .ThenInclude(p => p.PriorityDirectionModel)
                .Include(p => p.ProjectMemberModels)
                    .ThenInclude(p => p.ProjectModel)
                .Include(p => p.MemberTypesOfCooperationModels)
                    .ThenInclude(t => t.TypesOfCooperationModel)
                .Include(s => s.StatisticalInformationModels)
                .Include(u => u.UserMemberModels).AsNoTracking().FirstOrDefault(m => m.Id == id);

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
                    .Include(u => u.UserMemberModels).AsNoTracking().FirstOrDefault(m => m.Id == member.Id);

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
                        foreach(var oldMemberPriority in oldMember.MemberPriorityModels)
                        {
                            _memberPriorityService.Delete(oldMemberPriority.Id);
                        }

                        oldMember.MemberPriorityModels.Clear();

                        foreach (var memberPriority in member.MemberPriorityModels)
                        {
                            oldMember.MemberPriorityModels.Add(new MemberPriorityModel { MemberModelId = memberPriority.MemberModelId, 
                                PriorityDirectionModelId = memberPriority.PriorityDirectionModelId, EnrollmentDate = DateTime.Now });
                        }
                    }

                    if (!member.MemberTypesOfCooperationModels.Select(mt => mt.TypesOfCooperationModelId).ToArray().
                        SequenceEqual(oldMember.MemberTypesOfCooperationModels.Select(mt => mt.TypesOfCooperationModelId).ToArray()))
                    {
                        foreach (var memberTypes in oldMember.MemberTypesOfCooperationModels)
                        {
                            _memberTypesOfCooperationService.Delete(memberTypes.Id);
                        }

                        oldMember.MemberTypesOfCooperationModels.Clear();

                        foreach (var typesOfCooperation in member.MemberTypesOfCooperationModels)
                        {
                            oldMember.MemberTypesOfCooperationModels.Add(new MemberTypesOfCooperationModel
                            {
                                MemberModelId = typesOfCooperation.MemberModelId,
                                TypesOfCooperationModelId = typesOfCooperation.TypesOfCooperationModelId,
                                EnrollmentDate = DateTime.Now
                            });
                        }
                    }

                    if (!member.StatisticalInformationModels.Select(mt => mt.Id).ToArray().
                        SequenceEqual(oldMember.StatisticalInformationModels.Select(mt => mt.Id).ToArray()))
                    {
                        foreach (var oldStatInf in oldMember.StatisticalInformationModels)
                        {
                            _statisticalInformationService.Delete(oldStatInf.Id);
                        }

                        oldMember.StatisticalInformationModels.Clear();

                        foreach (var keyValue in member.StatisticalInformationModels)
                        {
                            oldMember.StatisticalInformationModels.Add(new StatisticalInformationModel
                            {
                                MemberModelId = keyValue.MemberModelId,
                                Name = keyValue.Name,
                                Key = keyValue.Key,
                                Value = keyValue.Value
                            });
                        }
                    }

                    if (!member.UserMemberModels.Select(u => u.Id).ToArray().
                        SequenceEqual(oldMember.UserMemberModels.Select(u => u.Id).ToArray()))
                    {
                        foreach (var oldUM in oldMember.UserMemberModels)
                        {
                            _userMemberService.Delete(oldUM.Id);
                        }

                        oldMember.UserMemberModels.Clear();

                        foreach (var user in member.UserMemberModels)
                        {
                            oldMember.UserMemberModels.Add(new UserMemberModel
                            {
                                MemberModelId = user.MemberModelId,
                                UserModelId = user.UserModelId,
                                Position = user.Position,
                                EnrollmentDate = DateTime.Now
                            });
                        }
                    }

                    if (!member.ProjectMemberModels.Select(p => p.ProjectModelId).ToArray().
                        SequenceEqual(oldMember.ProjectMemberModels.Select(p => p.ProjectModelId).ToArray()))
                    {
                        foreach (var oldPM in oldMember.ProjectMemberModels)
                        {
                            _projectMemberService.Delete(oldPM.Id);
                        }

                        oldMember.ProjectMemberModels.Clear();

                        foreach (var projectMember in member.ProjectMemberModels)
                        {
                            oldMember.ProjectMemberModels.Add(new ProjectMemberModel { MemberModelId = projectMember.MemberModelId, ProjectModelId = projectMember.ProjectModelId, EnrollmentDate = DateTime.Now });
                        }
                    }

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
                    .Include(u => u.UserMemberModels).AsNoTracking().FirstOrDefault(m => m.Id == id);

            if (!member.IsDelete && member != null)
            {
                try
                {
                    member.IsDelete = true;
                    

                    foreach (var memberPriority in member.MemberPriorityModels)
                    {
                        _memberPriorityService.Delete(memberPriority.Id);
                    }
                    member.MemberPriorityModels.Clear();

                    foreach (var projectMember in member.ProjectMemberModels)
                    {
                        _projectMemberService.Delete(projectMember.Id);
                    }
                    member.ProjectMemberModels.Clear();

                    foreach (var memberTypes in member.MemberTypesOfCooperationModels)
                    {
                        _memberTypesOfCooperationService.Delete(memberTypes.Id);
                    }
                    member.MemberTypesOfCooperationModels.Clear();

                    foreach (var memberPriority in member.MemberPriorityModels)
                    {
                        _memberPriorityService.Delete(memberPriority.Id);
                    }
                    member.MemberPriorityModels.Clear();

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

