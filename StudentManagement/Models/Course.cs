using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public decimal Fees { get; set; }

        public bool IsActive { get; set; } = true;
    }
}