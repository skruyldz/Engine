using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SompoEngine.Entites;

namespace SompoEngine.DataAccess
{
    public partial class SompoengineContext : DbContext
    {
        public virtual DbSet<ServiceRequestResponse> ServiceRequestResponses { get; set; }

        public SompoengineContext(DbContextOptions<SompoengineContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceRequestResponse>(entity =>
            {
                entity.ToTable("ServiceRequestResponse", "SampleEngine");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ProductNo).HasMaxLength(20);

                entity.Property(e => e.ProposalNo).HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}