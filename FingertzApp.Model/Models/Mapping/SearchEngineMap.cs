using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class SearchEngineMap : EntityTypeConfiguration<SearchEngine>
    {
        public SearchEngineMap()
        {
            // Primary Key
            this.HasKey(t => t.SE_Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.GroupBy)
                .HasMaxLength(50);

            this.Property(t => t.GroupCountry)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SearchEngines");
            this.Property(t => t.SE_Id).HasColumnName("SE_Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.GroupBy).HasColumnName("GroupBy");
            this.Property(t => t.GroupCountry).HasColumnName("GroupCountry");
        }
    }
}
