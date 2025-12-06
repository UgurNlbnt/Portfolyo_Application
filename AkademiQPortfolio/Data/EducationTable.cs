using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Data
{
    public partial class EducationTable
    {
        public int EducationId { get; set; }
        public string? Title { get; set; }
        public string? SchoolName { get; set; }
        public string? Years { get; set; }
        public int? AboutId { get; set; }

        public virtual AboutMeTable? About { get; set; }
    }
}
