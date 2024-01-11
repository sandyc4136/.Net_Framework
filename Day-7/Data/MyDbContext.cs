

using System;
using Day_7.Models;
using Microsoft.EntityFrameworkCore;

namespace Day_7.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
        // List of Tables to be operated by DbContext
       
      
        public DbSet<Guests> Guests { get; set; }

        // Join-Table Queries DTO are also registered here

        // ModelBuilder: 
    }
}



