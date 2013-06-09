using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FingertzApp.Model.Models.Mapping
{
    public class TaskMap : EntityTypeConfiguration<Task>
    {
        public TaskMap()
        {
            // Primary Key
            this.HasKey(t => t.TaskId);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Email)
                .HasMaxLength(200);

            this.Property(t => t.Piority)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Tasks");
            this.Property(t => t.TaskId).HasColumnName("TaskId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.AssigntoUser).HasColumnName("AssigntoUser");
            this.Property(t => t.EmailtoUser).HasColumnName("EmailtoUser");
            this.Property(t => t.PhraseId).HasColumnName("PhraseId");
            this.Property(t => t.ProId).HasColumnName("ProId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Detail).HasColumnName("Detail");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.DueDate).HasColumnName("DueDate");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Piority).HasColumnName("Piority");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Completed).HasColumnName("Completed");
            this.Property(t => t.CompletionDate).HasColumnName("CompletionDate");
            this.Property(t => t.ParentTaskId).HasColumnName("ParentTaskId");

            // Relationships
            this.HasOptional(t => t.PhraseManagement)
                .WithMany(t => t.Tasks)
                .HasForeignKey(d => d.PhraseId);
            this.HasOptional(t => t.Project)
                .WithMany(t => t.Tasks)
                .HasForeignKey(d => d.ProId);
            this.HasOptional(t => t.User)
                .WithMany(t => t.Tasks)
                .HasForeignKey(d => d.UserId);
            this.HasOptional(t => t.User1)
                .WithMany(t => t.Tasks1)
                .HasForeignKey(d => d.CreatedBy);
            this.HasOptional(t => t.User2)
                .WithMany(t => t.Tasks2)
                .HasForeignKey(d => d.AssigntoUser);
            this.HasOptional(t => t.User3)
                .WithMany(t => t.Tasks3)
                .HasForeignKey(d => d.UserId);

        }
    }
}
