using RUFR.Api.DataLayer;
using RUFR.Api.Model.Models;
using RUFR.Api.Service.Interfaces;

namespace RUFR.Api.Service.Services
{
    public class ProjectMemberService : MainService<ProjectMemberModel>, IProjectMemberService
    {
        public ProjectMemberService(IDbContext context) : base(context)
        {
        }
    }
}
