using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admission.Models
{
    public class StudentDocs
    {
        [Key]
        public int DocumentId { get; set; }
        [ForeignKey("ApplicationId")]
        public int ApplicationId { get; set; }
        public string DocumentType { get; set; }
        public string FilePath { get; set; }
        public string UploadDate {  get; set; }

        //Navigation Property
        public UserApplication UserApplications { get; set; }

    }
}
