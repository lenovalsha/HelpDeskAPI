namespace HelpDeskAPINew.Models
{
    public class Staff
    {
        [System.ComponentModel.DataAnnotations.Key]

        public string Name { get; set; }
        public string Password { get; set; }
        public string? DepartmentName { get; set; }
        public Department? Department { get; set; }
        public List <Ticket>? Tickets { get; set; }
        //public List<TicketChat>? TicketChats { get; set; }
        public byte[]? ProfilePicture { get; set; }

        public Staff()
        {
            Tickets = new List<Ticket>();
            //TicketChats = new List<TicketChat>();
        }

    }
}
