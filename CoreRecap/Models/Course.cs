using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRecap.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [Display(Name = "Course Title")]
        [Required(ErrorMessage = "Please Course Title must enter.")]
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
