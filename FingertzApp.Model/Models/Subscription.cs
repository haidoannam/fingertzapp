using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class Subscription
    {
        public Subscription()
        {
            this.Invoices = new List<Invoice>();
            this.Users = new List<User>();
        }

        public int SubId { get; set; }
        public string SubName { get; set; }
        public string SubPermission { get; set; }
        public Nullable<int> SubPrice { get; set; }
        public Nullable<int> SubAnnualPrice { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
