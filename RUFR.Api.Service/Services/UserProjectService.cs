using RUFR.Api.DataLayer;
using RUFR.Api.Model.Models;
using RUFR.Api.Service.Interfaces;


namespace RUFR.Api.Service.Services
{
    public class UserProjectService : MainService<UserProjectModel>, IUserProjectService
    {
        public UserProjectService(IDbContext context) : base(context)
        {
        }
    }
}
