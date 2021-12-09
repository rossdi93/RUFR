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
        public virtual ICollection<MemberModel> MemberModels { get; set; }

        /// <summary>
        /// Проекты
        /// </summary>
        public virtual ICollection<ProjectModel> ProjectModels { get; set; }

        public PriorityDirectionModel()
        {
            ProjectModels = new List<ProjectModel>();
            MemberModels = new List<MemberModel>();
        }
    }
}
