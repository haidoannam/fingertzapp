using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class PhraseManagement
    {
        public PhraseManagement()
        {
            this.Tasks = new List<Task>();
        }

        public int PhraseId { get; set; }
        public Nullable<int> ProId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
