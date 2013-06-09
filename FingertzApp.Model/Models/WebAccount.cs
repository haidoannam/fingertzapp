using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class WebAccount
    {
        public WebAccount()
        {
            this.SeedingManagements = new List<SeedingManagement>();
        }

        public int WA_Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public string Name { get; set; }
        public Nullable<int> EmailId { get; set; }
        public Nullable<int> DomainID { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public virtual Domain Domain { get; set; }
        public virtual Email Email { get; set; }
        public virtual ICollection<SeedingManagement> SeedingManagements { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
