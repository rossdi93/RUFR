using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUFR.Api.Model.Models
{
    /// <summary>
    /// Сущность дополнительных данных, выводимых в контексте статистической/краткой информации
    /// </summary>
    public class StatisticalInformationModel: BaseModel
    {
        public long MemberModelId { get; set; }

        public MemberModel MemberModel { get; set; }

        /// <summary>
        /// Ключ, может быть любым
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Значение, краткая информация для данного ключа 
        /// </summary>
        public string Value { get; set; }
    }
}
