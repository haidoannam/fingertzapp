using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class Domain
    {
        public Domain()
        {
            this.DomainRequests = new List<DomainRequest>();
            this.WebAccounts = new List<WebAccount>();
        }

        public int DomainId { get; set; }
        public string UserId { get; set; }
        public string CreatedBy { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> MozRank { get; set; }
        public Nullable<int> MozTrust { get; set; }
        public Nullable<int> AlexaRank { get; set; }
        public Nullable<int> PageRank { get; set; }
        public Nullable<int> AgeDomain { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Authority { get; set; }
        public string LastUpdate { get; set; }
        public virtual ICollection<DomainRequest> DomainRequests { get; set; }
        public virtual ICollection<WebAccount> WebAccounts { get; set; }
    }
}
