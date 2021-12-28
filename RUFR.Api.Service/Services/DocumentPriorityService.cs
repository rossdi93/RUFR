using RUFR.Api.DataLayer;
using RUFR.Api.Model.Models;
using RUFR.Api.Service.Interfaces;
namespace RUFR.Api.Service.Services
{
    public class DocumentPriorityService : MainService<DocumentPriorityModel>, IDocumentPriorityService
    {
        public DocumentPriorityService(IDbContext context) : base(context)
        {
        }
    }
}