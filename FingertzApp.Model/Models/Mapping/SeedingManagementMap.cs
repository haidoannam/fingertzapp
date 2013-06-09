using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class SeedingManagementMap : EntityTypeConfiguration<SeedingManagement>
    {
        public SeedingManagementMap()
        {
            // Primary Key
            this.HasKey(t => t.SM_Id);

            // Properties
            this.Property(t => t.Url)
                .HasMaxLength(500);

            this.Property(t => t.Title)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            this.Property(t => t.YourWeb)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.AnchorText)
                .HasMaxLength(50);

            this.Property(t => t.CountReply)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SeedingManagement");
            this.Property(t => t.SM_Id).HasColumnName("SM_Id");
            this.Property(t => t.ProId).HasColumnName("ProId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.YourWeb).HasColumnName("YourWeb");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.AnchorText).HasColumnName("AnchorText");
            this.Property(t => t.CountReply).HasColumnName("CountReply");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.DomainId).HasColumnName("DomainId");
            this.Property(t => t.WA_Id).HasColumnName("WA_Id");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
            this.Property(t => t.TaskId).HasColumnName("TaskId");

            // Relationships
            this.HasOptional(t => t.Project)
                .WithMany(t => t.SeedingManagements)
                .HasForeignKey(d => d.ProId);
            this.HasOptional(t => t.User)
                .WithMany(t => t.SeedingManagements)
                .HasForeignKey(d => d.UserId);
            this.HasOptional(t => t.User1)
                .WithMany(t => t.SeedingManagements1)
                .HasForeignKey(d => d.CreatedBy);
            this.HasOptional(t => t.WebAccount)
                .WithMany(t => t.SeedingManagements)
                .HasForeignKey(d => d.WA_Id);

        }
    }
}
