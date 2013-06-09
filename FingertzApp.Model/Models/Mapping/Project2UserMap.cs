using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class Project2UserMap : EntityTypeConfiguration<Project2User>
    {
        public Project2UserMap()
        {
            // Primary Key
            this.HasKey(t => t.ProUserId);

            // Properties
            this.Property(t => t.Permission)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Project2User");
            this.Property(t => t.ProUserId).HasColumnName("ProUserId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.ProId).HasColumnName("ProId");
            this.Property(t => t.Permission).HasColumnName("Permission");

            // Relationships
            this.HasOptional(t => t.Project)
                .WithMany(t => t.Project2User)
                .HasForeignKey(d => d.ProId);
            this.HasOptional(t => t.User)
                .WithMany(t => t.Project2User)
                .HasForeignKey(d => d.UserId);

        }
    }
}
