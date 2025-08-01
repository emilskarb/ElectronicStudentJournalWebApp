namespace ElectronicStudentJournal.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string NumerPesel { get; set; }
        public string NumerTelefonu { get; set; }
        public string AdresZamieszkania { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public List<TeachingAssignment> TeachingAssignments { get; set; } = new();
    }
}
