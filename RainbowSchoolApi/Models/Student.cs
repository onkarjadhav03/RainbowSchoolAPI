using System;
using System.Collections.Generic;

namespace RainbowSchoolApi.Models
{
    public partial class Student
    {
        public Student()
        {
            Marks = new HashSet<Mark>();
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int? ClassId { get; set; }
        public int? SubjectId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual Subject? Subject { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
    }
}
