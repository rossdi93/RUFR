using System;
using System.Collections.Generic;
using System.Text;

namespace RUFR.Api.Service.Auth
{
    public class AuthData
    {
        public string Token { get; set; }

        public string TokenExpirationTime { get; set; }

        public string Id { get; set; }
    }
}
