using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDeskAPINew.Models
{
    public class Category
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string Name { get; set; }
        public string PriorityName { get; set; }
        public Priority Priority { get; set; }

        //public ICollection<Ticket>? Tickets { get; set; }

    }
}
