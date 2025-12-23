using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Data
{
    public partial class SkillTable
    {
        public int SkillId { get; set; }
        public string? Title { get; set; }
        public byte? Levels { get; set; }
        public string? Test { get; set; }
    }
}
