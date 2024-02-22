using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Claim.Models;

namespace Claim.ClaimDBContext
{
    public partial class ClaimsDBContext : DbContext
    {
        public ClaimsDBContext()
        {
        }
        public ClaimsDBContext(DbContextOptions<ClaimsDBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Claims>? claims { get; set; }
        public virtual DbSet<Policy>? policy { get; set; }
        public virtual DbSet<Customer>? customer { get; set; }
        public virtual DbSet<Claimant>? claimant { get; set; }




        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Claims>(claim =>
        //    {
        //        claim.HasKey(c => c.ID);
        //        claim.ToTable("Claims");
        //        claim.Property(c => c.ID).HasColumnName("ID");
        //        claim.Property(c => c.ClaimantID).HasMaxLength(50).IsUnicode(false);
        //        claim.Property(c => c.PolicyId).HasMaxLength(50).IsUnicode(false);
        //        claim.Property(c => c.MobileNunber).HasMaxLength(50).IsUnicode(false);
        //        claim.Property(c => c.ClaimDetails).HasMaxLength(200).IsUnicode(false);
        //        claim.Property(c => c.SumAssured).IsUnicode(false);
        //        claim.Property(c => c.IsSelfProcess).IsUnicode(false);
        //        claim.Property(c => c.IsSubmitted).IsUnicode(false);
        //        OnModelCreatingPartial(modelBuilder);
        //    });
        //}
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
