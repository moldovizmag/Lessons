using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite("Data Source=product.db");
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public AppDbContext()
    {
    }
}
