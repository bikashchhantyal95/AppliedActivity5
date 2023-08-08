using System;
using static Android.Graphics.ImageDecoder;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AppliedActivity_5.Models
{
	public class ApplicationDBContext: DbContext
	{
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<CourseModel> Courses { get; set; }

        // Constructor to provide configuration options (optional)
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }
    }
}

