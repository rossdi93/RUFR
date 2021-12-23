﻿using RUFR.Api.DataLayer;
using RUFR.Api.Model.Models;
using RUFR.Api.Service.Interfaces;

namespace RUFR.Api.Service.Services
{
    public class UserDocumentService : MainService<UserMemberModel>, IUserMemberService
    {
        public UserDocumentService(IDbContext context) : base(context)
        {
        }
    }
}
