using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class Project
    {
        public Project()
        {
            this.DomainRequests = new List<DomainRequest>();
            this.Keywords = new List<Keyword>();
            this.PhraseManagements = new List<PhraseManagement>();
            this.Project2User = new List<Project2User>();
            this.SeedingManagements = new List<SeedingManagement>();
            this.Tasks = new List<Task>();
        }

        public int ProId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string ProName { get; set; }
        public string ProUrl { get; set; }
        public string Authority { get; set; }
        public Nullable<int> MozRank { get; set; }
        public Nullable<int> MozTrust { get; set; }
        public Nullable<int> AlexaRank { get; set; }
        public Nullable<int> PageRank { get; set; }
        public Nullable<int> AgeDomain { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Status { get; set; }
        public string ReportType { get; set; }
        public string ExactlyReportBy { get; set; }
        public Nullable<System.DateTime> LastReportDate { get; set; }
        public Nullable<System.DateTime> NextReportDate { get; set; }
        public Nullable<int> ClientId { get; set; }
        public virtual ICollection<DomainRequest> DomainRequests { get; set; }
        public virtual ICollection<Keyword> Keywords { get; set; }
        public virtual ICollection<PhraseManagement> PhraseManagements { get; set; }
        public virtual ICollection<Project2User> Project2User { get; set; }
        public virtual ICollection<SeedingManagement> SeedingManagements { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
