using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class KeywordHistoryMap : EntityTypeConfiguration<KeywordHistory>
    {
        public KeywordHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.KeyId);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("KeywordHistory");
            this.Property(t => t.KeyId).HasColumnName("KeyId");
            this.Property(t => t.SE_Id).HasColumnName("SE_Id");
            this.Property(t => t.CurrentRangking).HasColumnName("CurrentRangking");
            this.Property(t => t.CheckedDate).HasColumnName("CheckedDate");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasOptional(t => t.SearchEngine)
                .WithMany(t => t.KeywordHistories)
                .HasForeignKey(d => d.SE_Id);

        }
    }
}
