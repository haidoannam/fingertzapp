using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class Keyword
    {
        public int KeyId { get; set; }
        public Nullable<int> ProId { get; set; }
        public Nullable<int> SE_Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public string KeyName { get; set; }
        public Nullable<int> CurentRanking { get; set; }
        public Nullable<int> PreviousRanking { get; set; }
        public Nullable<int> TopRanking { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> LastCheckedDate { get; set; }
        public Nullable<int> LastCheckBy { get; set; }
        public string Status { get; set; }
        public virtual KeywordHistory KeywordHistory { get; set; }
        public virtual Project Project { get; set; }
        public virtual SearchEngine SearchEngine { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
    }
}
