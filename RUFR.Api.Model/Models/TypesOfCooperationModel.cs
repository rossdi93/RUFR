using System;
using System.Collections.Generic;
using System.Text;

namespace RUFR.Api.Model.Models
{
    public class TypesOfCooperationModel: BaseModel
    {
        /// <summary>
        /// описание вида сотрудничества 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// id участника
        /// </summary>
        public long MemberModelId { get; set; }

        /// <summary>
        /// навигационное свойство  
        /// </summary>
        public MemberModel MemberModel { get; set; }
    }
}
