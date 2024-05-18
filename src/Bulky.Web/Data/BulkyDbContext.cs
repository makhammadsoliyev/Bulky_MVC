﻿using Bulky.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.Web.Data;

public class BulkyDbContext : DbContext
{
    public BulkyDbContext(DbContextOptions<BulkyDbContext> options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
}
