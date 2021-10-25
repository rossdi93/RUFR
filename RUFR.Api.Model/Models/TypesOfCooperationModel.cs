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

        public ICollection<MemberModel> MemberModels { get; set; }

        public TypesOfCooperationModel()
        {
            MemberModels = new List<MemberModel>();
        }
    }
}
