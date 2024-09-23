using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admission.Models
{
    public class AdminAction
    {
        [Key]
        public int ActionId { get; set; }
        [ForeignKey("UserId")]
        public int AdminId { get; set; }
        [ForeignKey("ApplicationId")]
        public int ApplicationId { get; set; }
        public string ActionType { get; set; }
        public string ActionDetails { get; set; }
        public DateTime ActionDate { get; set; }
    }
}
