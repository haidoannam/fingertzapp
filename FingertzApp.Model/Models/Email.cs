using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class Email
    {
        public Email()
        {
            this.WebAccounts = new List<WebAccount>();
        }

        public int EmailId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public string Email1 { get; set; }
        public string MailBox { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<WebAccount> WebAccounts { get; set; }
    }
}
