using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class KeywordMap : EntityTypeConfiguration<Keyword>
    {
        public KeywordMap()
        {
            // Primary Key
            this.HasKey(t => t.KeyId);

            // Properties
            this.Property(t => t.KeyName)
                .HasMaxLength(200);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Keywords");
            this.Property(t => t.KeyId).HasColumnName("KeyId");
            this.Property(t => t.ProId).HasColumnName("ProId");
            this.Property(t => t.SE_Id).HasColumnName("SE_Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.KeyName).HasColumnName("KeyName");
            this.Property(t => t.CurentRanking).HasColumnName("CurentRanking");
            this.Property(t => t.PreviousRanking).HasColumnName("PreviousRanking");
            this.Property(t => t.TopRanking).HasColumnName("TopRanking");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.LastCheckedDate).HasColumnName("LastCheckedDate");
            this.Property(t => t.LastCheckBy).HasColumnName("LastCheckBy");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasRequired(t => t.KeywordHistory)
                .WithOptional(t => t.Keyword);
            this.HasOptional(t => t.Project)
                .WithMany(t => t.Keywords)
                .HasForeignKey(d => d.ProId);
            this.HasOptional(t => t.SearchEngine)
                .WithMany(t => t.Keywords)
                .HasForeignKey(d => d.SE_Id);
            this.HasOptional(t => t.User)
                .WithMany(t => t.Keywords)
                .HasForeignKey(d => d.UserId);
            this.HasOptional(t => t.User1)
                .WithMany(t => t.Keywords1)
                .HasForeignKey(d => d.LastCheckBy);
            this.HasOptional(t => t.User2)
                .WithMany(t => t.Keywords2)
                .HasForeignKey(d => d.UserId);

        }
    }
}
