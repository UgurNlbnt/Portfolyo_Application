using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Data
{
    public partial class MessageTable
    {
        public int MessageId { get; set; }
        public string? SenderNameSurname { get; set; }
        public string? SenderEmailAdress { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
    }
}
