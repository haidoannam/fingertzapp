using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            // Primary Key
            this.HasKey(t => t.ProId);

            // Properties
            this.Property(t => t.ProName)
                .HasMaxLength(50);

            this.Property(t => t.ProUrl)
                .HasMaxLength(200);

            this.Property(t => t.Authority)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.ReportType)
                .HasMaxLength(50);

            this.Property(t => t.ExactlyReportBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Projects");
            this.Property(t => t.ProId).HasColumnName("ProId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.ProName).HasColumnName("ProName");
            this.Property(t => t.ProUrl).HasColumnName("ProUrl");
            this.Property(t => t.Authority).HasColumnName("Authority");
            this.Property(t => t.MozRank).HasColumnName("MozRank");
            this.Property(t => t.MozTrust).HasColumnName("MozTrust");
            this.Property(t => t.AlexaRank).HasColumnName("AlexaRank");
            this.Property(t => t.PageRank).HasColumnName("PageRank");
            this.Property(t => t.AgeDomain).HasColumnName("AgeDomain");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ReportType).HasColumnName("ReportType");
            this.Property(t => t.ExactlyReportBy).HasColumnName("ExactlyReportBy");
            this.Property(t => t.LastReportDate).HasColumnName("LastReportDate");
            this.Property(t => t.NextReportDate).HasColumnName("NextReportDate");
            this.Property(t => t.ClientId).HasColumnName("ClientId");
        }
    }
}
