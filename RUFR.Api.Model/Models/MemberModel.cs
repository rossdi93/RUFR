using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RUFR.Api.Model.Models
{
    public class MemberModel: BaseModel
    {
        /// <summary>
        /// страна
        /// </summary>
        public string Countrys { get; set; }

        /// <summary>
        /// дата регистрации участинка
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// контент
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Logo
        /// </summary>
        public byte[] Logo { get; set; }

        /// <summary>
        /// язык
        /// </summary>
        public string Lang { get; set; }

        /// <summary>
        /// приоритетные направления
        /// </summary>
        public List<MemberPriorityModel> MemberPriorityModels { get; set; }

        /// <summary>
        /// виды сотрудничества
        /// </summary>
        public List<MemberTypesOfCooperationModel> MemberTypesOfCooperationModels { get; set; }

        /// <summary>
        /// Проекты
        /// </summary>
        public List<ProjectMemberModel> ProjectMemberModels { get; set; }

        public MemberModel()
        {
            ProjectMemberModels = new List<ProjectMemberModel>();
            MemberPriorityModels = new List<MemberPriorityModel>();
            MemberTypesOfCooperationModels = new List<MemberTypesOfCooperationModel>();
        }


    }
}
