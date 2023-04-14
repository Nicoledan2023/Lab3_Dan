
using Microsoft.EntityFrameworkCore;

namespace Lab3.Models;

public class Lab3Context : DbContext
{
	public Lab3Context(DbContextOptions<Lab3Context> options) : base(options)
	{
	}
	public DbSet<Product> Product { get; set; } = default!;
	public DbSet<LabUser> Users { get; set; } = default!;
}

