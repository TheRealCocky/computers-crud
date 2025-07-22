using Computer.Models;
using Microsoft.EntityFrameworkCore;

namespace Computer.Data;

public class ComputerContext : DbContext
{
   public ComputerContext(DbContextOptions<ComputerContext> options) : base(options) {}
      public DbSet<ComputerModel> Computers { get; set; }
}