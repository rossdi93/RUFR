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
        public virtual ICollection<PriorityDirectionModel> PriorityDirectionModels { get; set; }

        /// <summary>
        /// виды сотрудничества
        /// </summary>
        public virtual ICollection<TypesOfCooperationModel> TypesOfCooperationModels { get; set; }

        /// <summary>
        /// Проекты
        /// </summary>
        public virtual ICollection<ProjectModel> ProjectModels { get; set; }

        public MemberModel()
        {
            ProjectModels = new List<ProjectModel>();
            PriorityDirectionModels = new List<PriorityDirectionModel>();
            TypesOfCooperationModels = new List<TypesOfCooperationModel>();
        }


    }
}
