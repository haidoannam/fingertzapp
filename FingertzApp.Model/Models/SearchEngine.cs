using System;
using System.Collections.Generic;

namespace FingertzApp.Model.Models
{
    public partial class SearchEngine
    {
        public SearchEngine()
        {
            this.KeywordHistories = new List<KeywordHistory>();
            this.Keywords = new List<Keyword>();
        }

        public int SE_Id { get; set; }
        public string Name { get; set; }
        public string GroupBy { get; set; }
        public string GroupCountry { get; set; }
        public virtual ICollection<KeywordHistory> KeywordHistories { get; set; }
        public virtual ICollection<Keyword> Keywords { get; set; }
    }
}
