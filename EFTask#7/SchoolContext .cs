using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer; 

namespace EFTask_7;

public class SchoolContext : DbContext
{
	public DbSet<Teacher> Teachers { get; set; }
	public DbSet<Pupil> Pupils { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		// Use your connection string here
		optionsBuilder.UseSqlServer("Server=LAPTOP-F9NIKSL0\\MSSQLSERVER2022;Database=SchoolDB;integrated security=true; trustservercertificate=true");
	}
}
