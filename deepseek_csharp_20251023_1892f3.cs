// CinemaContext.cs
using Microsoft.EntityFrameworkCore;

public class CinemaContext : DbContext
{
    public DbSet<Film> Films { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=preserver\SQLEXPRESS;Database=ispp3101;Trusted_Connection=true;TrustServerCertificate=true;");
    }
}