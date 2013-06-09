using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class InvoiceMap : EntityTypeConfiguration<Invoice>
    {
        public InvoiceMap()
        {
            // Primary Key
            this.HasKey(t => t.InvoId);

            // Properties
            this.Property(t => t.SubPayFor)
                .HasMaxLength(50);

            this.Property(t => t.InvoiceType)
                .HasMaxLength(50);

            this.Property(t => t.InvoiceStatus)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Invoices");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.SubId).HasColumnName("SubId");
            this.Property(t => t.SubPayFor).HasColumnName("SubPayFor");
            this.Property(t => t.InvoiceTime).HasColumnName("InvoiceTime");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.CouponCode).HasColumnName("CouponCode");
            this.Property(t => t.TotalPrice).HasColumnName("TotalPrice");
            this.Property(t => t.AutoRenew).HasColumnName("AutoRenew");
            this.Property(t => t.InvoiceType).HasColumnName("InvoiceType");
            this.Property(t => t.InvoiceStatus).HasColumnName("InvoiceStatus");

            // Relationships
            this.HasOptional(t => t.Subscription)
                .WithMany(t => t.Invoices)
                .HasForeignKey(d => d.SubId);
            this.HasOptional(t => t.User)
                .WithMany(t => t.Invoices)
                .HasForeignKey(d => d.UserId);

        }
    }
}
