using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class EmailMap : EntityTypeConfiguration<Email>
    {
        public EmailMap()
        {
            // Primary Key
            this.HasKey(t => t.EmailId);

            // Properties
            this.Property(t => t.Email1)
                .HasMaxLength(500);

            this.Property(t => t.Password)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Emails");
            this.Property(t => t.EmailId).HasColumnName("EmailId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Email1).HasColumnName("Email");
            this.Property(t => t.MailBox).HasColumnName("MailBox");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");

            // Relationships
            this.HasOptional(t => t.User)
                .WithMany(t => t.Emails)
                .HasForeignKey(d => d.UserId);
            this.HasOptional(t => t.User1)
                .WithMany(t => t.Emails1)
                .HasForeignKey(d => d.CreatedBy);

        }
    }
}
