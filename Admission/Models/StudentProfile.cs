using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admission.Models
{
    public class StudentProfile
    {
        [Key]
        [ForeignKey("UserId")]
        public int StudentId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string PrevEducation { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string ParentName { get; set; }
    }
}
