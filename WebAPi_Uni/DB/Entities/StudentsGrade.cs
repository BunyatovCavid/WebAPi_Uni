using System;
using System.Collections.Generic;

namespace WebAPi_Uni.DB.Entities
{
    public partial class StudentsGrade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
