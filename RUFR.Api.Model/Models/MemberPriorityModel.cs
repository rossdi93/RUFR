
namespace RUFR.Api.Model.Models
{
    public class MemberPriorityModel
    {
        public long Id { get; set; }
        public long MemberModelId { get; set; }
        public MemberModel MemberModel { get; set; }
        public long PriorityDirectionModelId { get; set; }
        public PriorityDirectionModel PriorityDirectionModel { get; set; }

        public System.DateTime EnrollmentDate { get; set; }
    }
}
