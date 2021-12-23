using RUFR.Api.DataLayer;
using RUFR.Api.Model.Models;
using RUFR.Api.Service.Interfaces;

namespace RUFR.Api.Service.Services
{
    public class StatisticalInformationService : MainService<StatisticalInformationModel>, IStatisticalInformationService
    {
        public StatisticalInformationService(IDbContext context) : base(context)
        {
        }
    }
}
