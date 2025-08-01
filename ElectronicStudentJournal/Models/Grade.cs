using System.ComponentModel.DataAnnotations;

namespace ElectronicStudentJournal.Models
{
    public class Grade
    {
        public int GradeId { get; set; }

        [Required]
        public int GradeName { get; set; }

        public string Subject { get; set; }

        public DateTime GradeReceivingDate { get; set; }

        public DateTime GradeSubmissionDate { get; set; }

        public bool IsGradeVerbal { get; set; }

        public int GradeWeight { get; set; }

        public string GradeDescription { get; set; }
        
        public int Section { get; set; }


        public ICollection<StudentModel> Student { get; set; }


    }
}
