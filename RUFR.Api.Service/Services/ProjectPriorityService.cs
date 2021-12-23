using RUFR.Api.DataLayer;
using RUFR.Api.Model.Models;
using RUFR.Api.Service.Interfaces;

namespace RUFR.Api.Service.Services
{
    public class ProjectPriorityService : MainService<ProjectPriorityModel>, IProjectPriorityService
    {
        public ProjectPriorityService(IDbContext context) : base(context)
        {
        }
    }
}