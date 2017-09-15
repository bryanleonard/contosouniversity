using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }

        //The Grade property is an enum. The question mark after the Grade type declaration indicates that the Grade 
        //property is nullable. A grade that's null is different from a zero grade -- null means a grade isn't known 
        //or hasn't been assigned yet.
        //https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro
    }
}
