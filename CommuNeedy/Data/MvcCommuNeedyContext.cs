using System;
using CommuNeedy.Models;
using CommuNeedy.Models.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommuNeedy.Data
{
    public class MvcCommuNeedyContext : IdentityDbContext<User>
    {
        public MvcCommuNeedyContext(DbContextOptions<MvcCommuNeedyContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());
        }

        public DbSet<Need> Needs { get; set; }
        public DbSet<User> User { get; set; }
    }
}
