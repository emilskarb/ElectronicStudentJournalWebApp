using System.ComponentModel.DataAnnotations;

namespace ElectronicStudentJournal.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Proszę podać imię")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Imię musi mieć od 2 do 30 znaków")]
        [RegularExpression(@"^[\p{L}]+$", ErrorMessage = "Nie można używać cyfr lub znaków spejcalnych")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwisko")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Nazwisko musi mieć od 2 do 30 znaków")]
        [RegularExpression(@"^[\p{L}]+$", ErrorMessage = "Nie można używać cyfr lub znaków spejcalnych")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Proszę podać numer telefonu")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Można używać tylko cyfr")]
        public int PeselNumber { get; set; }


        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Proszę podać adres zamieszkania")]
        public string HomeAddress { get; set; }

        public Grade Grade { get; set; }
    }
}
