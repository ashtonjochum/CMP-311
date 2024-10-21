using Microsoft.EntityFrameworkCore;

namespace CollectionApi.Models;

public class CollectionContext : DbContext
{
    public CollectionContext(DbContextOptions<CollectionContext> options)
        : base(options)
    {
    }

    public DbSet<CollectionItem> CollectionItems { get; set; } = null!;
}