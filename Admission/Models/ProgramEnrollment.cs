
using System.ComponentModel.DataAnnotations;

namespace Admission.Models
{
    public class ProgramEnrollment
    {
        [Key]
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public int Duration { get; set; }
        public double ProgramFee { get; set; }
    }
}
