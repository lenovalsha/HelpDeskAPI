namespace HelpDeskAPINew.Models
{
    public class Priority
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string Name { get; set; }
        public string Color { get; set; }

        public List<Category>? Categories { get; set; }
        public Priority()
        {
            Categories = new List<Category>();
        }
    }
}
