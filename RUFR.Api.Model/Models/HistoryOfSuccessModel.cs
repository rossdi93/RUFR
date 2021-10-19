using System;
using System.Collections.Generic;
using System.Text;

namespace RUFR.Api.Model.Models
{
    public class HistoryOfSuccessModel : BaseModel
    {
        /// <summary>
        /// страны
        /// </summary>
        public string Countrys { get; set; }

        /// <summary>
        /// тип истории
        /// </summary>
        public TypesOfHistory TypesOfHistory { get; set; }


        /// <summary>
        /// описание вида сотрудничества 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// дата события
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// контент истории
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Logo
        /// </summary>
        public byte[] Logo { get; set; }

        /// <summary>
        /// автор истрории
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// язык
        /// </summary>
        public string Lang { get; set; }

    }
}
