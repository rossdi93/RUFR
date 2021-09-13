using RUFR.Api.DataLayer;
using RUFR.Api.Model.Models;
using RUFR.Api.Service.Interfaces;

namespace RUFR.Api.Service.Services
{
    public class MemberService : MainService<MemberModel>, IMemberService
    {
        public MemberService(IDbContext context) : base(context)
        {
        }
    }
}
