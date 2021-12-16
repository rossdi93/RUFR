using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUFR.Api.Model.Models
{
    public class UserProjectModel
    {
        public long Id { get; set; }

        public string Position { get; set; }

        public long UserModelId { get; set; }

        public UserModel UserModel { get; set; }

        public long ProjectModelId { get; set; }

        public ProjectModel ProjectModel { get; set; }

        public System.DateTime EnrollmentDate { get; set; }
    }
}
