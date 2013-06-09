using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class SeedingManagement
    {
        public int SM_Id { get; set; }
        public Nullable<int> ProId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string YourWeb { get; set; }
        public string Type { get; set; }
        public string AnchorText { get; set; }
        public string CountReply { get; set; }
        public string Status { get; set; }
        public Nullable<int> DomainId { get; set; }
        public Nullable<int> WA_Id { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<int> TaskId { get; set; }
        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual WebAccount WebAccount { get; set; }
    }
}
