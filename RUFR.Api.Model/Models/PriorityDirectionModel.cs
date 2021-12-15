using System;
using System.Collections.Generic;
using System.Text;

namespace RUFR.Api.Model.Models
{
    public class PriorityDirectionModel: BaseModel
    {
        /// <summary>
        /// описание направления
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Участники
        /// </summary>
        public List<MemberPriorityModel> MemberPriorityModels { get; set; }

        /// <summary>
        /// Проекты
        /// </summary>
        public List<ProjectMemberModel> ProjectMemberModels { get; set; }

        public PriorityDirectionModel()
        {
            ProjectMemberModels = new List<ProjectMemberModel>();
            MemberPriorityModels = new List<MemberPriorityModel>();
        }
    }
}
