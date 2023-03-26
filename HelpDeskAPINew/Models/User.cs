using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDeskAPINew.Models
{
    public class User
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Ticket>? Tickets { get; set; }
        //public List <TicketChat>? TicketChats { get; set; }

        public User()
        {
            Tickets = new List<Ticket>();
            //TicketChats = new List<TicketChat>();
        }

    }
}
