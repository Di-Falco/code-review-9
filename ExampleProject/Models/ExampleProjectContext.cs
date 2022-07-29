using Microsoft.EntityFrameworkCore;

namespace ExampleProject.Models
{
  public class ExampleProjectContext : DbContext
  {
    public DbSet<Example> Examples { get; set; }

    public ExampleProjectContext(DbContextOptions options) : base(options) { }
  }
}