using System;
using System.Collections.Generic;
using System.Text;

namespace RUFR.Api.Model.Models
{
    public class PriorityDirectionModel: BaseModel
    {
        /// <summary>
        /// описание напрвление
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// id проектов по направлению
        /// </summary>
        public long ProjectModelId { get; set; }

        /// <summary>
        /// навигационное свойство  
        /// </summary>
        public ProjectModel ProjectModel { get; set; }

        /// <summary>
        /// id участника по направлению
        /// </summary>
        public long MemberModelId { get; set; }

        /// <summary>
        /// навигационное свойство  
        /// </summary>
        public MemberModel MemberModel { get; set; }
    }
}
