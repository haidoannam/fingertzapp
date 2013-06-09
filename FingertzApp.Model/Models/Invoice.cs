using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class Invoice
    {
        public int InvoId { get; set; }
        public int? UserId { get; set; }
        public int? SubId { get; set; }
        public string SubPayFor { get; set; }
        public int? InvoiceTime { get; set; }
        public int? Price { get; set; }
        public int? CouponCode { get; set; }
        public int? TotalPrice { get; set; }
        public bool? AutoRenew { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceStatus { get; set; }
        public virtual Subscription Subscription { get; set; }
        public virtual User User { get; set; }
    }
}
