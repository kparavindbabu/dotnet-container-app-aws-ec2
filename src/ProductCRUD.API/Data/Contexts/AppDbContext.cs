using Microsoft.EntityFrameworkCore;
using ProductCRUD.Data.Models;

namespace ProductCRUD.Data.Contexts;

public class AppDbContext : DbContext
{

    public DbSet<Product> Products { get; set; } = null!;

    /// <summary>
    /// ctor 
    /// </summary>
    /// <param name="dbContextOptions"></param>
    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions)
        : base(dbContextOptions)
    {

    }
}