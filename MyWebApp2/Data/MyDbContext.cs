using System;
using Microsoft.EntityFrameworkCore;
using MyWebApp2.Models;

namespace MyWebApp2.Data
{
	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions options) : base(options)
		{

		}

		// List of Tables to be operated by DbContext
		public DbSet<Employee> Employees{ get; set; }
		public DbSet<Dept> Depts { get; set; }
        public DbSet<Guest> Guests { get; set; }

        // Join-Table Queries DTO are also registered here

        // ModelBuilder: 
    }
}

