using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models.Input
{
    public class TestModel
    {
        [Required]
        public string FirstName { get; set; }

        [MaxLength(3)]
        public string LastName { get; set; }
    }
}