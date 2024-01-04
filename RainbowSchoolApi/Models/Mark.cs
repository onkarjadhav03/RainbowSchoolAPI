using System;
using System.Collections.Generic;

namespace RainbowSchoolApi.Models
{
    public partial class Mark
    {
        public int MarkId { get; set; }
        public int? StudentId { get; set; }
        public int? SubjectId { get; set; }
        public int Mark1 { get; set; }

        public virtual Student? Student { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
