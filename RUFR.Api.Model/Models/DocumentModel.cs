using System.Text.Json.Serialization;

namespace RUFR.Api.Model.Models
{
    public class DocumentModel : BaseModel
    {
        /// <summary>
        /// автор документа
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// описание 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// дата добавления документа
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// тип документа
        /// </summary>
        public string Type { get; set; }


        /// <summary>
        /// сам документ
        /// </summary>
        [JsonIgnore]
        public byte[] DocByte { get; set; }

        /// <summary>
        /// язык
        /// </summary>
        public string Lang { get; set; }
    }
}