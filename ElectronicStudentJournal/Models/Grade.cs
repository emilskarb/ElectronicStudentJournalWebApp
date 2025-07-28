namespace ElectronicStudentJournal.Models
{
    public class Grade
    {
        public int GradeId { get; set; }

        public int GradeName { get; set; }
        
        public int Section { get; set; }


        public ICollection<Student> Student { get; set; }


    }
}
