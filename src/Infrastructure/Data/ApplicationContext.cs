using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class ApplicationContext : IdentityDbContext
{
    public DbSet<Daily> Dailies { get; set; }
}
