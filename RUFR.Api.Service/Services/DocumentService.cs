using RUFR.Api.DataLayer;
using RUFR.Api.Model.Models;
using RUFR.Api.Service.Interfaces;

namespace RUFR.Api.Service.Services
{
    public class DocumentService : MainService<DocumentModel>, IDocumentService
    {
        public DocumentService(IDbContext context) : base(context)
        {
        }
    }
}