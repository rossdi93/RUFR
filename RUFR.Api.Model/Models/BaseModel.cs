using System;
using System.Collections.Generic;
using System.Text;

namespace RUFR.Api.Model.Models
{
    public class BaseModel
    {
        /// <summary>
        /// Id сущности
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Флаг удаления
        /// </summary>
        public bool IsDelete { get; set; }

    }
}
