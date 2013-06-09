using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class PhraseManagementMap : EntityTypeConfiguration<PhraseManagement>
    {
        public PhraseManagementMap()
        {
            // Primary Key
            this.HasKey(t => t.PhraseId);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.Note)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PhraseManagements");
            this.Property(t => t.PhraseId).HasColumnName("PhraseId");
            this.Property(t => t.ProId).HasColumnName("ProId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasOptional(t => t.Project)
                .WithMany(t => t.PhraseManagements)
                .HasForeignKey(d => d.ProId);
            this.HasOptional(t => t.User)
                .WithMany(t => t.PhraseManagements)
                .HasForeignKey(d => d.UserId);
            this.HasOptional(t => t.User1)
                .WithMany(t => t.PhraseManagements1)
                .HasForeignKey(d => d.CreatedBy);

        }
    }
}
