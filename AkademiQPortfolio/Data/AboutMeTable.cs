using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Data
{
    public partial class AboutMeTable
    {
        public AboutMeTable()
        {
            AwardTables = new HashSet<AwardTable>();
            EducationTables = new HashSet<EducationTable>();
        }

        public int AboutId { get; set; }
        public string? NameSurname { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Cvpath { get; set; }
        public string? ImagePath { get; set; }

        public virtual ICollection<AwardTable> AwardTables { get; set; }
        public virtual ICollection<EducationTable> EducationTables { get; set; }
    }
}
