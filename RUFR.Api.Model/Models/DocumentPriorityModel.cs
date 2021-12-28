
namespace RUFR.Api.Model.Models
{
    public class DocumentPriorityModel
    {
        public long Id { get; set; }
        public long DocumentModelId { get; set; }
        public DocumentModel DocumentModel { get; set; }
        public long PriorityDirectionModelId { get; set; }
        public PriorityDirectionModel PriorityDirectionModel { get; set; }
        public System.DateTime EnrollmentDate { get; set; }
    }
}
