using Microsoft.EntityFrameworkCore;

namespace Bulky.Web.Data;

public class BulkyDbContext : DbContext
{
    public BulkyDbContext(DbContextOptions<BulkyDbContext> options) : base(options) { }
}
