using System;
using System.Collections.Generic;
using System.Text;

namespace RUFR.Api.Service.Interfaces
{
    /// <summary>
    /// Интерфейс по работе с токенами
    /// </summary>
    public interface IAuthService
    {
        string HashPassword(string password);
        bool VerifyPassword(string actualPass, string hashedPass);

    }
}