using System;

namespace RUFR.Api.Model.Models
{
    public class EventModel : BaseModel
    {
        /// <summary>
        /// дата события
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// тема события
        /// </summary>
        public string Theme { get; set; }

        /// <summary>
        /// контент события
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Logo
        /// </summary>
        public byte[] Logo { get; set; }

        /// <summary>
        /// тип события
        /// </summary>
        public TypeEven TypeEven { get; set; }
    }
}
