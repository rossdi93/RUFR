﻿using System;
using System.Collections.Generic;
using System.Text;

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
        /// приоритетные направления
        /// </summary>
        public ICollection<PriorityDirectionModel> PriorityDirectionModels { get; set; }

        /// <summary>
        /// виды сотрудничества
        /// </summary>
        public ICollection<TypesOfCooperationModel> TypesOfCooperationModels { get; set; }

        public MemberModel()
        {
            PriorityDirectionModels = new List<PriorityDirectionModel>();
            TypesOfCooperationModels = new List<TypesOfCooperationModel>();
        }

    }
}
