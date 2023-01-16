using Back_end.Models;
using System.Collections.Generic;

namespace Back_end.ViewModels
{
    public class TicketsVM
    {
        public TicketsTitle TicketsTitles { get; set; }
        public TicketAbout TicketAbouts { get; set; }
        public List<Faqs> Faqsses { get; set; }

    }
}
