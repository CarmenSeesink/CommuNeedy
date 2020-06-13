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


            builder.Entity<Donation>()
                .HasOne(d => d.Owner)
                .WithMany(o => o.Donations)
                .HasForeignKey(d => d.OwnerId);

            builder.Entity<DonationNeed>()
                .HasKey(dn => new { dn.NeedId, dn.DonationId });

            builder.Entity<DonationNeed>()
                .HasOne(dn => dn.Need)
                .WithMany(n => n.DonationNeeds)
                .HasForeignKey(dn => dn.DonationId);

            builder.Entity<DonationNeed>()
                .HasOne(dn => dn.Donation)
                .WithMany(d => d.DonationNeeds)
                .HasForeignKey(dn => dn.NeedId);

        }

        public DbSet<Need> Needs { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Donation> Donation { get; set; }
        public DbSet<DonationNeed> DonationNeed { get; set; }
    }
}
