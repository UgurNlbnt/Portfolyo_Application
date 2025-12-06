using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Data
{
    public partial class ServiceDetailTable
    {
        public int ServiceDetailId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
        public int? ServiceId { get; set; }

        public virtual ServiceTable? Service { get; set; }
    }
}
