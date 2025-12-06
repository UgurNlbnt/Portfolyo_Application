using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Data
{
    public partial class ServiceTable
    {
        public ServiceTable()
        {
            ServiceDetailTables = new HashSet<ServiceDetailTable>();
        }

        public int ServiceId { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<ServiceDetailTable> ServiceDetailTables { get; set; }
    }
}
