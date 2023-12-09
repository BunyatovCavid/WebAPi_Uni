using System;
using System.Collections.Generic;

namespace WebAPi_Uni.DB.Entities
{
    public partial class Course
    {

        public Course()
        {
            StudentsGrade = new();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<StudentsGrade> StudentsGrade { get; set; }
    }
}
