using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class WhileLabel
    {
        public int UserId { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }
        public string Footertxt { get; set; }
        public string Status { get; set; }
        public string Domain { get; set; }
        public virtual User User { get; set; }
    }
}
