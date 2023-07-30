using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BL
{
    public class DoctorEditVM
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(10)]
        public string Specialization { get; set; } = string.Empty;
        [Required]
        [Range(5000, 25000,ErrorMessage ="The {0} is between {1} and {2}")]
        public decimal Salary { get; set; }

    }
}
