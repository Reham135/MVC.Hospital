
using System.ComponentModel.DataAnnotations;

namespace Hospital.BL
{
    public class DoctorAddVM
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]

        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(10)]
        [MinLength(3, ErrorMessage = " {0} length must be less than {1}")]

        public string Specialization { get; set; } = string.Empty;
        [Required]
        [Range(5000, 25000, ErrorMessage = "The {0} is between {1} and {2}")]

        public decimal Salary { get; set; }
        public int PerformanceRate { get; set; }

    }
}


