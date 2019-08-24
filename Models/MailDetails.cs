using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Models
{
    public class MailDetails
    {
        public int MailDetails_Id { get; set; }
        public int Mail_Id { get; set; }
        public int Sender_Id { get; set; }
        public int Receiver_Id { get; set; }
        public Users Users { get; set; }
        public Mail Mail { get; set; }

        public MailDetails() { }
    }
}