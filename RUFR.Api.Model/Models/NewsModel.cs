using System;
using System.Collections.Generic;
using System.Text;

namespace RUFR.Api.Model.Models
{
    public class NewsModel: BaseModel
    {
        /// <summary>
        /// дата новости
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// тема новости
        /// </summary>
        public string Theme { get; set; }

        /// <summary>
        /// автор новости
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Logo
        /// </summary>
        public byte[] Logo { get; set; }

        /// <summary>
        /// контент истории
        /// </summary>
        public string Content { get; set; }
    }
}
