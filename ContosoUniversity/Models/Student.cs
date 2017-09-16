using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        //The Enrollments property is a navigation property. Navigation properties hold other entities that are related to this 
        //entity. In this case, the Enrollments property of a Student entity will hold all of the Enrollment entities that are 
        //related to that Student entity. In other words, if a given Student row in the database has two related Enrollment rows 
        //(rows that contain that student's primary key value in their StudentID foreign key column), that Student entity's 
        //Enrollments navigation property will contain those two Enrollment entities.
        //https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}


//https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/migrations