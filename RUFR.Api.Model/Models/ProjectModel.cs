using System;
using System.Collections.Generic;
using System.Text;

namespace RUFR.Api.Model.Models
{
    public class ProjectModel : BaseModel
    {
        /// <summary>
        /// страны
        /// </summary>
        public string Countrys { get; set; }

        /// <summary>
        /// описание 
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// стадия проекта
        /// </summary>
        public ProjectStage ProjectStage { get; set; }

        /// <summary>
        /// вид проекта
        /// </summary>
        public TypeOfProject TypeOfProject { get; set; }

        /// <summary>
        /// дата события
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// контент проекта
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// приоритетные направления
        /// </summary>
        public ICollection<PriorityDirectionModel> Priorities { get; set;}

        /// <summary>
        /// Logo
        /// </summary>
        public byte[] Logo { get; set; }

        /// <summary>
        /// язык
        /// </summary>
        public string Lang { get; set; }
    }
}
