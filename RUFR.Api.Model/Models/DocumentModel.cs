using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace RUFR.Api.Model.Models
{
    [DataContract]
    public class DocumentModel : BaseModel
    {
        [DataMember]
        /// <summary>
        /// автор документа
        /// </summary>
        public string Author { get; set; }

        [DataMember]
        /// <summary>
        /// описание 
        /// </summary>
        public string Description { get; set; }

        [DataMember]
        /// <summary>
        /// дата добавления документа
        /// </summary>
        public string Date { get; set; }

        [DataMember]
        /// <summary>
        /// тип документа
        /// </summary>
        public string Type { get; set; }

        [DataMember]
        /// <summary>
        /// Наименование загружаемого файла
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// сам документ
        /// </summary>
        public byte[] DocByte { get; set; }

        [DataMember]
        /// <summary>
        /// язык
        /// </summary>
        public string Lang { get; set; }

        [DataMember]
        /// <summary>
        /// Пользователи
        /// </summary>
        public List<UserDocumentModel> UserDocumentModels { get; set; }
    }
}