using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.Company)
                .HasMaxLength(100);

            this.Property(t => t.ShortName)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.FirstName)
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .HasMaxLength(50);

            this.Property(t => t.Address1)
                .HasMaxLength(200);

            this.Property(t => t.Address2)
                .HasMaxLength(200);

            this.Property(t => t.City)
                .HasMaxLength(100);

            this.Property(t => t.State)
                .HasMaxLength(10);

            this.Property(t => t.ZipCode)
                .HasMaxLength(10);

            this.Property(t => t.Country)
                .HasMaxLength(50);

            this.Property(t => t.LoginId)
                .HasMaxLength(50);

            this.Property(t => t.LoginPassword)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(200);

            this.Property(t => t.TypeAccount)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.ShortName).HasColumnName("ShortName");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.LoginId).HasColumnName("LoginId");
            this.Property(t => t.LoginPassword).HasColumnName("LoginPassword");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.TypeAccount).HasColumnName("TypeAccount");
            this.Property(t => t.ParentAccount).HasColumnName("ParentAccount");
            this.Property(t => t.SubId).HasColumnName("SubId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.UserSubcriotionTime).HasColumnName("UserSubcriotionTime");
            this.Property(t => t.UserExpiredTime).HasColumnName("UserExpiredTime");
            this.Property(t => t.RegisterDate).HasColumnName("RegisterDate");

            // Relationships
            this.HasOptional(t => t.Subscription)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.SubId);

        }
    }
}
