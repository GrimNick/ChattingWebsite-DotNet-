using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using bcmp.Areas.Identity.Data;

namespace bcmp.Data;

public class bcmpContext : IdentityDbContext<IdentityUser>
{
    public bcmpContext(DbContextOptions<bcmpContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<bcmp.Areas.Identity.Data.Product> Product { get; set; } = default!;
}
