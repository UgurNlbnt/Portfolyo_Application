using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Data
{
    public partial class LatestNewTable
    {
        public int LatestId { get; set; }
        public DateTime? Date { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
    }
}
