namespace HelpDeskAPINew.Models
{
    public class TicketChat
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public Ticket Ticket { get; set; }
        public string Comment { get; set; }

    }
}
