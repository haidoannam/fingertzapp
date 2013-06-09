using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class DomainRequest
    {
        public int RequestId { get; set; }
        public string Type { get; set; }
        public Nullable<int> DomainId { get; set; }
        public Nullable<int> ProId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Status { get; set; }
        public virtual Domain Domain { get; set; }
        public virtual Project Project { get; set; }
    }
}
