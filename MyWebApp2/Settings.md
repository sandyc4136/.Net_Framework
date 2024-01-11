
#### Steps to start with a Web Project in .Net
- Create a web project using MVC
- Create a Folder name  "Data" to add DB context
- Give a suitable name to the DB context class like "MySqlDbContext".
- This MySqlDbContest should inherit DbContext of Microsoft.Entity.EntityFrameworkCore;
- Initialize the constructor.

```C#
namespace MyWebApp2.Data
{
	public class MyDbContext : DbContext
	{
        // Constructor
		public MyDbContext(DbContextOptions options) : base(options)
		{

		}
        // list of tables to be operated by DbContext
		public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }

        // ModelBuilder
        
    }
}

```
- Register the model classes with DbContext File so that the model classes come under jurisdiction of Entity framework
- Add migration ( dotnet ef  migrations add  <migrationName>)
- Update Database/ Create table in Database ( dotnet ef database update)
- Create a Controller for your entity
- Inside that controller , Create a private variable of DbContext type to perform any operations with the tables. 
    - Ex : private MyDbConext _context;
