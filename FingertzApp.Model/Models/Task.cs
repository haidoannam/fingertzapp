using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class Task
    {
        public int TaskId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> AssigntoUser { get; set; }
        public Nullable<int> EmailtoUser { get; set; }
        public Nullable<int> PhraseId { get; set; }
        public Nullable<int> ProId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string Email { get; set; }
        public string Piority { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> Completed { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public Nullable<int> ParentTaskId { get; set; }
        public virtual PhraseManagement PhraseManagement { get; set; }
        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual User User3 { get; set; }
    }
}
