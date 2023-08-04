using System;
using System.ComponentModel.DataAnnotations;

namespace AppliedActivity_5.Models
{
	public class CourseModel
	{
        // Primary Key
        [Key]
        public int Id { get; set; }

        // Course Name
        [Required]
        public string Name { get; set; }

        // Course Code
        [Required]
        public string Code { get; set; }

        // Course Credit Hours
        [Required]
        public int CreditHours { get; set; }
    }
}

