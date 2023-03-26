namespace HelpDeskAPINew.Models
{
    public class UserTicket
    {
        public int Id { get; set; }
        public User User { get; set; }
        //public ICollection<Ticket>? Tickets { get; set; }

    }
}
