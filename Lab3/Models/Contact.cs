using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz podać imię")]
        [StringLength(maximumLength: 50, ErrorMessage = "zbyt długo")]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [DataType(DataType.Date)]
        public string? Birth { get; set; }
    }
}
