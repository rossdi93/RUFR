using RUFR.Api.DataLayer;
using RUFR.Api.Model.Models;
using RUFR.Api.Service.Interfaces;
namespace RUFR.Api.Service.Services
{
    public class MemberPriorityService : MainService<MemberPriorityModel>, IMemberPriorityService
    {
        public MemberPriorityService(IDbContext context) : base(context)
        {
        }
    }
}
