namespace HelpDeskAPINew.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CategoryName { get; set; }
        public Category Category { get; set; }
        public string Username { get; set; }
        public User User { get; set; }
        public string StatusName { get; set; }
        public string? StaffName { get; set; }
        public Staff? Staff { get; set; }
        public Status Status { get; set; }
        public List<TicketChat>? TicketChats { get; set; }
        public Ticket()
        {
            TicketChats = new List<TicketChat>();
        }

    }
}
