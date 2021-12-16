using System;
using System.Collections.Generic;

namespace RUFR.Api.Model.Models
{
    /// <summary>
    /// класс пользователя
    /// </summary>
    public class UserModel: BaseModel
    {
        /// <summary>
        /// логин пользователя
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// пароль пользователя
        /// </summary>
        public string Pass { get; set; }

        /// <summary>
        /// почта
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// дата регистрации пользователя
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// роль пользователя
        /// </summary>
        public UserRole Role { get; set; }

        /// <summary>
        /// Logo
        /// </summary>
        public byte[] Logo { get; set; }

        /// <summary>
        /// описание 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// приоритетные направления
        /// </summary>
        public List<UserMemberModel> UserMemberModels { get; set; }

        /// <summary>
        /// участники
        /// </summary>
        public List<UserProjectModel> UserProjectModels { get; set; }

        /// <summary>
        /// документы
        /// </summary>
        public List<UserDocumentModel> UserDocumentModels { get; set; }


    }
}
