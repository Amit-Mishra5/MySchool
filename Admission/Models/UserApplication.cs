using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admission.Models
{
    public class UserApplication
    {
        [Key]
        public int ApplicationId { get; set; }
        [ForeignKey("UserId")]
        public int StudentId { get; set; }
        public string AdmissionStatus { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime ApproveDate { get; set; }
        public string RejectionReason { get; set; }
        public string  Notes { get; set; }

        //Navigation Property
        public User Users { get; set; }
    }
}
