using System.ComponentModel.DataAnnotations;

namespace HelpDeskAPINew.Models
{
    public class Department
    {
        [Key]
        public string Name { get; set; }
        public List<Staff>? Staff { get; set; }

        public Department()
        {
            Staff = new List<Staff>();
        }

    }
}
