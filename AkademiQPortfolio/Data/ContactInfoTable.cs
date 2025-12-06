using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Data
{
    public partial class ContactInfoTable
    {
        public int ContactId { get; set; }
        public string? Description { get; set; }
        public string? FirstPhone { get; set; }
        public string? SecondPhone { get; set; }
        public string? PhoneIcon { get; set; }
        public string? Address { get; set; }
        public string? AdressIcon { get; set; }
        public string? FirstMail { get; set; }
        public string? SecondMail { get; set; }
        public string? MailIcon { get; set; }
    }
}
