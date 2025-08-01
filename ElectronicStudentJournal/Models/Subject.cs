namespace ElectronicStudentJournal.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<TeachingAssignment> TeachingAssignments { get; set; } = new();
    }
}
