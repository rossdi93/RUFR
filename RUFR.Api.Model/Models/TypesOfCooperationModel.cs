using System.Collections.Generic;

namespace RUFR.Api.Model.Models
{
    public class TypesOfCooperationModel: BaseModel
    {
        /// <summary>
        /// описание вида сотрудничества 
        /// </summary>
        public string Description { get; set; }

        public List<MemberTypesOfCooperationModel> MemberTypesOfCooperationModels { get; set; }

        public TypesOfCooperationModel()
        {
            MemberTypesOfCooperationModels = new List<MemberTypesOfCooperationModel>();
        }
    }
}
