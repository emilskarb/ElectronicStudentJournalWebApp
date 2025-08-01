using System.ComponentModel.DataAnnotations;

namespace ElectronicStudentJournal.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings =false, ErrorMessage ="Please provide user name")]
        public string? Login { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide password")]
        public string? Password { get; set; }
    }
}
