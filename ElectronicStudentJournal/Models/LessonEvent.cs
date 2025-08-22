namespace ElectronicStudentJournal.Models;

public class LessonEvent
{
    public string Subject { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public string Classroom { get; set; }
}
