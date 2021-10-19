using System;

namespace RUFR.Api.Model.Models
{
    /// <summary>
    /// класс пользователя
    /// </summary>
    public class UserModel: BaseModel
    {
        /// <summary>
        /// логин польователя
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
        /// флаг админ или нет
        /// </summary>
        public bool Admin { get; set; }

    }
}
