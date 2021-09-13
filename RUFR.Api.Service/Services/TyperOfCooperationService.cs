using RUFR.Api.DataLayer;
using RUFR.Api.Model.Models;
using RUFR.Api.Service.Interfaces;

namespace RUFR.Api.Service.Services
{
    public class TyperOfCooperationService : MainService<TypesOfCooperationModel>, ITyperOfCooperationService
    {
        public TyperOfCooperationService(IDbContext context) : base(context)
        {
        }
    }
}
