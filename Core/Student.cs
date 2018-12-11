using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Core
{
    public class Student
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Mobile { get; set; }
        public DateTime Dob { get; set; }
        //public int CourseId { get; set; }
        //[ForeignKey("CourseId")]
        //public Course Course { get; set; }
        //public List<Course> Courses { get; set; }
    }
}
