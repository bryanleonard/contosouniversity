using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        // An enrollment record is for a single course, so there's a CourseID foreign key property and a Course navigation property
        // An enrollment record is for a single student, so there's a StudentID foreign key property and a Student navigation property
        public Course Course { get; set; }
        public Student Student { get; set; }

        //The Grade property is an enum. The question mark after the Grade type declaration indicates that the Grade 
        //property is nullable. A grade that's null is different from a zero grade -- null means a grade isn't known 
        //or hasn't been assigned yet.
        //https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro
    }
}
