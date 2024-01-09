using System;
using Microsoft.EntityFrameworkCore;

namespace MyWebApp2.Data
{
	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions options) : base(options)
		{

		}
		// public DbSet<Student> Students { get; set; }
    }
}

