using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class DomainMap : EntityTypeConfiguration<Domain>
    {
        public DomainMap()
        {
            // Primary Key
            this.HasKey(t => t.DomainId);

            // Properties
            this.Property(t => t.UserId)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.CreatedBy)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Url)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Type)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Authority)
                .HasMaxLength(50);

            this.Property(t => t.LastUpdate)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Domains");
            this.Property(t => t.DomainId).HasColumnName("DomainId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.MozRank).HasColumnName("MozRank");
            this.Property(t => t.MozTrust).HasColumnName("MozTrust");
            this.Property(t => t.AlexaRank).HasColumnName("AlexaRank");
            this.Property(t => t.PageRank).HasColumnName("PageRank");
            this.Property(t => t.AgeDomain).HasColumnName("AgeDomain");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Authority).HasColumnName("Authority");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
        }
    }
}
