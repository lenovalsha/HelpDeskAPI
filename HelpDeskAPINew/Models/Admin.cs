using System.ComponentModel.DataAnnotations;

namespace HelpDeskAPINew.Models
{
    public class Admin
    {
        [Key]
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
