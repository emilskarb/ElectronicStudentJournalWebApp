namespace ElectronicStudentJournal.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> Students { get; set; } = new();
        public List<TeachingAssignment> TeachingAssignments { get; set; } = new();
    }
}
