using ElectronicStudentJournal.Pages.Account;

namespace ElectronicStudentJournal.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }
        public int AccessLevel { get; set; }

    }
}
