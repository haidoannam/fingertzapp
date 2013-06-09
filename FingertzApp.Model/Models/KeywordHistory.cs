using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class KeywordHistory
    {
        public int KeyId { get; set; }
        public Nullable<int> SE_Id { get; set; }
        public int CurrentRangking { get; set; }
        public Nullable<System.DateTime> CheckedDate { get; set; }
        public string Status { get; set; }
        public virtual SearchEngine SearchEngine { get; set; }
        public virtual Keyword Keyword { get; set; }
    }
}
