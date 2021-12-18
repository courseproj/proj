using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace CryptoPanel.Models.Contexsts
{
    public class EntityContext : DbContext
    {
        public DbSet<Stats> Stats { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Update> Updates { get; set; }
        public IConfiguration Configuration { get; }

        public EntityContext(DbContextOptions<EntityContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

