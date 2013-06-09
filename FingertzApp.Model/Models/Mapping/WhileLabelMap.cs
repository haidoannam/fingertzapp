using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class WhileLabelMap : EntityTypeConfiguration<WhileLabel>
    {
        public WhileLabelMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Logo)
                .HasMaxLength(200);

            this.Property(t => t.CompanyName)
                .HasMaxLength(200);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.Domain)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("WhileLabels");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Logo).HasColumnName("Logo");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.Footertxt).HasColumnName("Footertxt");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Domain).HasColumnName("Domain");

            // Relationships
            this.HasRequired(t => t.User)
                .WithOptional(t => t.WhileLabel);

        }
    }
}
