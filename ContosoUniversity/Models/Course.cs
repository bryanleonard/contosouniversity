using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //specifies that primary key values are provided by the user rather than the DB
        [Display(Name = "Course Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 1)]
        public string Title { get; set; }

        [Range(0, 50)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; } //A course is assigned to one department

        public Department Department { get; set; } // Navigation property

        public ICollection<Enrollment> Enrollments { get; set; } //A course can have any number of students enrolled in i

        public ICollection<CourseAssignment> CourseAssignments { get; set; } // A course may be taught by multiple instructors, 

        //DatabaseGenerated - Basically, this attribute lets you enter the primary key for the course
        //rather than having the database generate it
    }
}
