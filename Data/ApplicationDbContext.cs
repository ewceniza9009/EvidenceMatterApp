using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Models;

namespace BlazorApp1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MattersModel> Matters { get; set; }
        public DbSet<EvidenceModel> Evidence { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); 

            builder.Entity<EvidenceModel>()
                .HasOne(e => e.Matter) 
                .WithMany(m => m.Evidence) 
                .HasForeignKey(e => e.MatterId) 
                .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}