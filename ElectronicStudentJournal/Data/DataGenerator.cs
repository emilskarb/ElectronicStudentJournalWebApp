using Bogus;
using Bogus.Extensions.Poland;
using ElectronicStudentJournal.Models;
using ElectronicStudentJournal.Data;

namespace ElectronicStudentJournal.Data;

public class DataGenerator
{
    string[] zbiorTestowy = { "test1", "test2", "test3" };

    Faker<StudentModel> studentModelFake;   //reguły dla tworzenia sztucznych rekordów

    public DataGenerator()
    {
        Randomizer.Seed = new Random(123);      //zawsze przy generowaniu będziemy zaczynać od takiego samego rekordu

        //var sztudentID = 1;
        //studentModelFake = new Faker<StudentModel>()
        //    //.RuleFor(user => user.StudentId, faker => faker.Random.Int(1, 10000))     //reguła będzie dotyczyć Id 
        //    .RuleFor(user => user.StudentId, faker => sztudentID++)
        //    .RuleFor(u => u.FirstName, f => f.Name.FirstName())
        //    .RuleFor(u => u.LastName, f => f.Name.LastName())
        //    .RuleFor(u => u.Age, f => f.Random.Int(1, 100))
        //    .RuleFor(u => u.PeselNumber, f => f.Person.Pesel())
        //    .RuleFor(u => u.BirthDate, f => f.Date.Between(new DateTime(1980, 01, 01), new DateTime(2025, 05, 25)))
        //    //.RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumberFormat())
        //    .RuleFor(u => u.PhoneNumber, f => f.Random.Replace("### ### ###"))
        //    //.RuleFor(u => u.HomeAddress, f => f.Address.StreetAddress())
        //    //.RuleFor(u => u.HomeAddress, f => f.PickRandomParam<string>())
        //    .RuleFor(u => u.HomeAddress, f => f.PickRandomParam(zbiorTestowy))
        //    //.CustomInstantiator(u => u.)
        //    .RuleFor(u => u.Rating, f => f.PickRandom<GradeRating>());

        var sztudentID = 1;
        studentModelFake = new Faker<StudentModel>()
            .Rules((f, u) => 
                {
                     u.StudentId = sztudentID++;
                     u.FirstName = f.Name.FirstName();
                     u.LastName = f.Name.LastName();
                     u.Age = f.Random.Int(1, 100);
                     u.PeselNumber = f.Person.Pesel();
                     u.BirthDate = f.Date.Between(new DateTime(1980, 01, 01), new DateTime(2025, 05, 25));
                     u.PhoneNumber = f.Random.Replace("### ### ###");
                     u.PhoneNumber = f.Phone.PhoneNumberFormat();
                     u.HomeAddress = f.PickRandomParam(zbiorTestowy);
                     u.Rating = f.PickRandom<GradeRating>();
                });
    }



    public StudentModel GenerateStudent()
    {
        return studentModelFake.Generate();
    }

    public IEnumerable<StudentModel> GenerateManyStudents()
    {
        return studentModelFake.GenerateForever();
    }
}