using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class SubscriptionMap : EntityTypeConfiguration<Subscription>
    {
        public SubscriptionMap()
        {
            // Primary Key
            this.HasKey(t => t.SubId);

            // Properties
            this.Property(t => t.SubName)
                .HasMaxLength(100);

            this.Property(t => t.SubPermission)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Subscriptions");
            this.Property(t => t.SubId).HasColumnName("SubId");
            this.Property(t => t.SubName).HasColumnName("SubName");
            this.Property(t => t.SubPermission).HasColumnName("SubPermission");
            this.Property(t => t.SubPrice).HasColumnName("SubPrice");
            this.Property(t => t.SubAnnualPrice).HasColumnName("SubAnnualPrice");
        }
    }
}
