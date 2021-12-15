﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUFR.Api.Model.Models
{
    public class ProjectMemberModel
    {
        public long Id { get; set; }
        public long MemberModelId { get; set; }
        public MemberModel MemberModel { get; set; }
        public long ProjectModelId { get; set; }
        public ProjectModel ProjectModel { get; set; }

        public System.DateTime EnrollmentDate { get; set; }
    }
}
