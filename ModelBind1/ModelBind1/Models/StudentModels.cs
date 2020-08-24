using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ModelBind1.Models
{
    public class StudentModels:DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Course { get; set; }
    }

    public class Student
    {
        [Key, Display(Name = "Email ID")]
        [ScaffoldColumn(false)]
        public int studentID { get; set; }
        [Required, StringLength(40), Display(Name = "Last Name")]
        public string Lastname { get; set; }
        [Required,StringLength(40),Display(Name ="First Name")]
        public string Firstname { get; set; }
        [Required,StringLength(40),Display(Name ="Email ID")]
        public string Email { get; set; }
        [EnumDataType(typeof(Academic)),Display(Name ="Academic")]
        public Academic year { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public decimal? Grade { get; set; }
     //   public virtualCourse Course { get; set; }
     //   public virtualCourse Student { get; set; }
    }

    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set;}
    }

    public enum Academic
    {
        Freshman,
        Sophomore,
        Junior,
        Senior
    }
}