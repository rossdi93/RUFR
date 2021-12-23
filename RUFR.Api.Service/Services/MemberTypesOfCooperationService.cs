using RUFR.Api.DataLayer;
using RUFR.Api.Model.Models;
using RUFR.Api.Service.Interfaces;

namespace RUFR.Api.Service.Services
{
    public class MemberTypesOfCooperationService : MainService<MemberTypesOfCooperationModel>, IMemberTypesOfCooperationService
    {
        public MemberTypesOfCooperationService(IDbContext context) : base(context)
        {
        }
    }
}
