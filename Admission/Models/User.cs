using System.ComponentModel.DataAnnotations;

namespace Admission.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly Created {  get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}
