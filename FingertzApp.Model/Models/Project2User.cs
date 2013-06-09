using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class Project2User
    {
        public int ProUserId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> ProId { get; set; }
        public string Permission { get; set; }
        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
    }
}
