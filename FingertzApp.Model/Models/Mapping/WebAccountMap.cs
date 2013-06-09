using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class WebAccountMap : EntityTypeConfiguration<WebAccount>
    {
        public WebAccountMap()
        {
            // Primary Key
            this.HasKey(t => t.WA_Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Password)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WebAccounts");
            this.Property(t => t.WA_Id).HasColumnName("WA_Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.EmailId).HasColumnName("EmailId");
            this.Property(t => t.DomainID).HasColumnName("DomainID");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");

            // Relationships
            this.HasOptional(t => t.Domain)
                .WithMany(t => t.WebAccounts)
                .HasForeignKey(d => d.DomainID);
            this.HasOptional(t => t.Email)
                .WithMany(t => t.WebAccounts)
                .HasForeignKey(d => d.EmailId);
            this.HasOptional(t => t.User)
                .WithMany(t => t.WebAccounts)
                .HasForeignKey(d => d.UserId);
            this.HasOptional(t => t.User1)
                .WithMany(t => t.WebAccounts1)
                .HasForeignKey(d => d.CreatedBy);

        }
    }
}
