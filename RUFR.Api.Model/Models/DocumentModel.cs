using System.Collections.Generic;
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
        /// Наименование загружаемого файла
        /// </summary>
        public string FileName { get; set; }

        [JsonIgnore]
        /// <summary>
        /// сам документ
        /// </summary>
        public byte[] DocByte { get; set; }

        /// <summary>
        /// язык
        /// </summary>
        public string Lang { get; set; }

        /// <summary>
        /// контент
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Пользователи
        /// </summary>
        public List<UserDocumentModel> UserDocumentModels { get; set; }

        /// <summary>
        /// приоритетные направления
        /// </summary>
        public List<DocumentPriorityModel> DocumentPriorityModels { get; set; }
    }
}