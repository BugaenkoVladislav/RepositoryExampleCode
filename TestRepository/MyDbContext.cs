using Microsoft.EntityFrameworkCore;
using TestRepository.Entities;

namespace TestRepository;

public class MyDbContext:DbContext
{
    public virtual DbSet<User> Users { get; set; }
    public MyDbContext()
    {
        
    }

    public MyDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}