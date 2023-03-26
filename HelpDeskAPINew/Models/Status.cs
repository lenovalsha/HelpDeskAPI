namespace HelpDeskAPINew.Models
{
    public class Status
    {
        [System.ComponentModel.DataAnnotations.Key]

        public string Name { get; set; }
        public string Color { get; set; }

        public List<Ticket> Ticket { get; set; }
        public Status()
        {
            Ticket = new List<Ticket>();
        }


    }
}
