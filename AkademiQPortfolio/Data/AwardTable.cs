using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Data
{
    public partial class AwardTable
    {
        public int AwardId { get; set; }
        public string? Title { get; set; }
        public string? AwardDescription { get; set; }
        public int? AboutId { get; set; }

        public virtual AboutMeTable? About { get; set; }
    }
}
