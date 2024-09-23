using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admission.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public string Message { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool IsRead { get; set; }
    }
}
