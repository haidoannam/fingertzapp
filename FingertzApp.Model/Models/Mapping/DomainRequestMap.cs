using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class DomainRequestMap : EntityTypeConfiguration<DomainRequest>
    {
        public DomainRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestId);

            // Properties
            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DomainRequests");
            this.Property(t => t.RequestId).HasColumnName("RequestId");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.DomainId).HasColumnName("DomainId");
            this.Property(t => t.ProId).HasColumnName("ProId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasOptional(t => t.Domain)
                .WithMany(t => t.DomainRequests)
                .HasForeignKey(d => d.DomainId);
            this.HasOptional(t => t.Project)
                .WithMany(t => t.DomainRequests)
                .HasForeignKey(d => d.ProId);

        }
    }
}
