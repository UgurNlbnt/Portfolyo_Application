using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Data
{
    public partial class CatagoryTable
    {
        public CatagoryTable()
        {
            ProjectTables = new HashSet<ProjectTable>();
        }

        public int CatagoryId { get; set; }
        public string? CategoryName { get; set; }

        public virtual ICollection<ProjectTable> ProjectTables { get; set; }
    }
}
