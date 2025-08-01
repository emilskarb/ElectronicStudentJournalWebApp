namespace ElectronicStudentJournal.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public int Value { get; set; }
        public string Description { get; set; }  // Opcjonalny opis oceny

        public DateTime Date { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int TeachingAssignmentId { get; set; }
        public TeachingAssignment TeachingAssignment { get; set; }
    }
}
