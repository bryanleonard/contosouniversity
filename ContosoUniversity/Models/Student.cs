using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [DisplayName("Last name")]
        [StringLength(50)] // instead of Required, could do [StringLength(50, MinimumLength=1)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name can not be longer than 50 characters.")]
        [DisplayName("First Name")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return $"{LastName}, {FirstMidName}"; }
        }

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