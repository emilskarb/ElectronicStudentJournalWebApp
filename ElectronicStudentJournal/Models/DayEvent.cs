namespace ElectronicStudentJournal.Models;

public class DayEvent
{
	public int DayEventId { get; set; }
	public string Note { get; set; }
	public DateTime EventDate { get; set; } = new DateTime(1900, 1, 1);
	public DateTime FromDate { get; set; } = new DateTime(1900, 1, 1);
	public DateTime ToDate { get; set; } = new DateTime(1900, 1, 1);
	public int DateValue { get; set; }
	public string DayName { get; set; }
	public string Message { get; set; }

}
