using System;
using System.Collections.Generic;

namespace RainbowSchoolApi.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Marks = new HashSet<Mark>();
            Students = new HashSet<Student>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; } = null!;

        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
