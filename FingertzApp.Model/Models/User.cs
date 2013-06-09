using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class User
    {
        public User()
        {
            this.Emails = new List<Email>();
            this.Emails1 = new List<Email>();
            this.Invoices = new List<Invoice>();
            this.Keywords = new List<Keyword>();
            this.Keywords1 = new List<Keyword>();
            this.Keywords2 = new List<Keyword>();
            this.PhraseManagements = new List<PhraseManagement>();
            this.PhraseManagements1 = new List<PhraseManagement>();
            this.Project2User = new List<Project2User>();
            this.SeedingManagements = new List<SeedingManagement>();
            this.SeedingManagements1 = new List<SeedingManagement>();
            this.Tasks = new List<Task>();
            this.Tasks1 = new List<Task>();
            this.Tasks2 = new List<Task>();
            this.Tasks3 = new List<Task>();
            this.WebAccounts = new List<WebAccount>();
            this.WebAccounts1 = new List<WebAccount>();
        }

        public int UserId { get; set; }
        public string Company { get; set; }
        public string ShortName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string LoginId { get; set; }
        public string LoginPassword { get; set; }
        public string Email { get; set; }
        public string TypeAccount { get; set; }
        public Nullable<int> ParentAccount { get; set; }
        public Nullable<int> SubId { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> UserSubcriotionTime { get; set; }
        public Nullable<System.DateTime> UserExpiredTime { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Email> Emails1 { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Keyword> Keywords { get; set; }
        public virtual ICollection<Keyword> Keywords1 { get; set; }
        public virtual ICollection<Keyword> Keywords2 { get; set; }
        public virtual ICollection<PhraseManagement> PhraseManagements { get; set; }
        public virtual ICollection<PhraseManagement> PhraseManagements1 { get; set; }
        public virtual ICollection<Project2User> Project2User { get; set; }
        public virtual ICollection<SeedingManagement> SeedingManagements { get; set; }
        public virtual ICollection<SeedingManagement> SeedingManagements1 { get; set; }
        public virtual Subscription Subscription { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<Task> Tasks1 { get; set; }
        public virtual ICollection<Task> Tasks2 { get; set; }
        public virtual ICollection<Task> Tasks3 { get; set; }
        public virtual ICollection<WebAccount> WebAccounts { get; set; }
        public virtual ICollection<WebAccount> WebAccounts1 { get; set; }
        public virtual WhileLabel WhileLabel { get; set; }
    }
}
