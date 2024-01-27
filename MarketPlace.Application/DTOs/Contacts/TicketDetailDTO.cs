using MarketPlace.Domain.Models.Contacts;

namespace MarketPlace.Application.DTOs.Contacts
{
    public class TicketDetailDTO
    {
        public Ticket Ticket { get; set; }

        public List<TicketMessage> TicketMessages { get; set; }
    }
}
