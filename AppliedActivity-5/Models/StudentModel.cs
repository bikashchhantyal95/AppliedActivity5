using System;
using System.ComponentModel.DataAnnotations;

namespace AppliedActivity_5.Models
{
	public class StudentModel
	{
        // Primary Key
        [Key]
        public int Id { get; set; }

        // Student's First Name
        [Required]
        public string FirstName { get; set; }

        // Student's Last Name
        [Required]
        public string LastName { get; set; }

        // Student's Age
        [Required]
        public int Age { get; set; }
    }
}

