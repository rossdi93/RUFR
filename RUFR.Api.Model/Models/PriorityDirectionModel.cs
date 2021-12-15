using System.Collections.Generic;

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
        public List<ProjectPriorityModel> ProjectPriorityModels { get; set; }

        public PriorityDirectionModel()
        {
            ProjectPriorityModels = new List<ProjectPriorityModel>();
            MemberPriorityModels = new List<MemberPriorityModel>();
        }
    }
}
