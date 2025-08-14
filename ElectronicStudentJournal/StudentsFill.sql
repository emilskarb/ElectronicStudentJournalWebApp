USE JournalDb;
GO


INSERT INTO Students (FirstName, LastName, Age, PeselNumber, BirthDate, PhoneNumber, HomeAddress) VALUES
('Anna', 'Nowak', 17, 12345678901, '2007-03-15', '501 123 456', 'ul. Polna 1, 00-001 Warszawa'),
('Piotr', 'Kowalski', 18, 23456789012, '2006-08-22', '602 234 567', 'ul. Leśna 5, 00-001 Warszawa'),
('Katarzyna', 'Wiśniewska', 16, 34567890123, '2008-01-30', '703 345 678', 'ul. Słoneczna 10, 00-001 Warszawa'),
('Krzysztof', 'Wójcik', 17, 45678901234, '2007-05-11', '504 456 789', 'ul. Krótka 12, 00-001 Warszawa'),
('Agnieszka', 'Kowalczyk', 18, 56789012345, '2006-11-02', '605 567 890', 'ul. Szkolna 25, 00-001 Warszawa'),
('Marcin', 'Kamiński', 16, 67890123456, '2008-02-14', '706 678 901', 'ul. Ogrodowa 3, 00-001 Warszawa'),
('Joanna', 'Lewandowska', 17, 78901234567, '2007-09-19', '507 789 012', 'ul. Lipowa 7, 00-001 Warszawa'),
('Tomasz', 'Zieliński', 18, 89012345678, '2006-04-05', '608 890 123', 'ul. Brzozowa 8, 00-001 Warszawa'),
('Magdalena', 'Szymańska', 16, 90123456789, '2008-06-25', '709 901 234', 'ul. Kwiatowa 15, 00-001 Warszawa'),
('Paweł', 'Woźniak', 17, 11223344556, '2007-12-01', '501 112 233', 'ul. Kościelna 2, 00-001 Warszawa'),
('Karolina', 'Dąbrowska', 18, 22334455667, '2006-07-08', '602 223 344', 'ul. Polna 33, 00-001 Warszawa'),
('Michał', 'Kozłowski', 16, 33445566778, '2008-03-03', '703 334 455', 'ul. Leśna 44, 00-001 Warszawa'),
('Monika', 'Jankowska', 17, 44556677889, '2007-10-10', '504 445 566', 'ul. Słoneczna 55, 00-001 Warszawa'),
('Jakub', 'Mazur', 18, 55667788990, '2006-02-28', '605 556 677', 'ul. Krótka 66, 00-001 Warszawa'),
('Natalia', 'Kwiatkowska', 16, 66778899001, '2008-04-20', '706 667 788', 'ul. Szkolna 77, 00-001 Warszawa');
GO

SELECT 'Wstawiono 15 rekordów do tabeli Students.' AS Status;
GO


--var list = new List<StudentModel>();
--list.Add(new StudentModel() { StudentId = 1, FirstName = "John", LastName = "Doe", Age = 20, PeselNumber = "12345678901", BirthDate = new DateTime(2003, 1, 15), PhoneNumber = "123-456-789", HomeAddress = "123 Main St", Rating = GradeRating.A });
--list.Add(new StudentModel() { StudentId = 2, FirstName = "Jane", LastName = "Smith", Age = 22, PeselNumber = "23456789012", BirthDate = new DateTime(2001, 2, 20), PhoneNumber = "234-567-890", HomeAddress = "234 Elm St", Rating = GradeRating.B });
--list.Add(new StudentModel() { StudentId = 3, FirstName = "Alice", LastName = "Johnson", Age = 21, PeselNumber = "34567890123", BirthDate = new DateTime(2002, 3, 25), PhoneNumber = "345-678-901", HomeAddress = "345 Oak St", Rating = GradeRating.A });
--list.Add(new StudentModel() { StudentId = 4, FirstName = "Bob", LastName = "Brown", Age = 23, PeselNumber = "45678901234", BirthDate = new DateTime(2000, 4, 30), PhoneNumber = "456-789-012", HomeAddress = "456 Pine St", Rating = GradeRating.C });
--list.Add(new StudentModel() { StudentId = 5, FirstName = "Charlie", LastName = "Davis", Age = 19, PeselNumber = "56789012345", BirthDate = new DateTime(2004, 5, 5), PhoneNumber = "567-890-123", HomeAddress = "567 Maple St", Rating = GradeRating.B });
--list.Add(new StudentModel() { StudentId = 6, FirstName = "Diana", LastName = "Garcia", Age = 20, PeselNumber = "67890123456", BirthDate = new DateTime(2003, 6, 10), PhoneNumber = "678-901-234", HomeAddress = "678 Cedar St", Rating = GradeRating.A });
--list.Add(new StudentModel() { StudentId = 7, FirstName = "Ethan", LastName = "Martinez", Age = 22, PeselNumber = "78901234567", BirthDate = new DateTime(2001, 7, 15), PhoneNumber = "789-012-345", HomeAddress = "789 Birch St", Rating = GradeRating.B });
--list.Add(new StudentModel() { StudentId = 8, FirstName = "Fiona", LastName = "Hernandez", Age = 21, PeselNumber = "89012345678", BirthDate = new DateTime(2002, 8, 20), PhoneNumber = "890-123-456", HomeAddress = "890 Spruce St", Rating = GradeRating.C });
--list.Add(new StudentModel() { StudentId = 9, FirstName = "George", LastName = "Lopez", Age = 23, PeselNumber = "90123456789", BirthDate = new DateTime(2000, 9, 25), PhoneNumber = "901-234-567", HomeAddress = "901 Fir St", Rating = GradeRating.A });
--list.Add(new StudentModel() { StudentId = 10, FirstName = "Hannah", LastName = "Wilson", Age = 19, PeselNumber = "01234567890", BirthDate = new DateTime(2004, 10, 30), PhoneNumber = "012-345-678", HomeAddress = "012 Willow St", Rating = GradeRating.B });
--list.Add(new StudentModel() { StudentId = 11, FirstName = "Ian", LastName = "Anderson", Age = 20, PeselNumber = "12345678901", BirthDate = new DateTime(2003, 11, 5), PhoneNumber = "123-456-789", HomeAddress = "123 Chestnut St", Rating = GradeRating.A });
--list.Add(new StudentModel() { StudentId = 12, FirstName = "Julia", LastName = "Thomas", Age = 22, PeselNumber = "23456789012", BirthDate = new DateTime(2001, 12, 10), PhoneNumber = "234-567-890", HomeAddress = "234 Ash St", Rating = GradeRating.B });
--list.Add(new StudentModel() { StudentId = 13, FirstName = "Kevin", LastName = "Jackson", Age = 21, PeselNumber = "34567890123", BirthDate = new DateTime(2002, 1, 15), PhoneNumber = "345-678-901", HomeAddress = "345 Poplar St", Rating = GradeRating.C });
--list.Add(new StudentModel() { StudentId = 14, FirstName = "Laura", LastName = "White", Age = 23, PeselNumber = "45678901234", BirthDate = new DateTime(2000, 2, 20), PhoneNumber = "456-789-012", HomeAddress = "456 Walnut St", Rating = GradeRating.A });
--list.Add(new StudentModel() { StudentId = 15, FirstName = "Michael", LastName = "Harris", Age = 19, PeselNumber = "56789012345", BirthDate = new DateTime(2004, 3, 25), PhoneNumber = "567-890-123", HomeAddress = "567 Cherry St", Rating = GradeRating.B });
--list.Add(new StudentModel() { StudentId = 16, FirstName = "Nina", LastName = "Martin", Age = 20, PeselNumber = "67890123456", BirthDate = new DateTime(2003, 4, 30), PhoneNumber = "678-901-234", HomeAddress = "678 Peach St", Rating = GradeRating.A });
--list.Add(new StudentModel() { StudentId = 17, FirstName = "Oscar", LastName = "Thompson", Age = 22, PeselNumber = "78901234567", BirthDate = new DateTime(2001, 5, 5), PhoneNumber = "789-012-345", HomeAddress = "789 Plum St", Rating = GradeRating.B });
--list.Add(new StudentModel() { StudentId = 18, FirstName = "Paula", LastName = "Garcia", Age = 21, PeselNumber = "89012345678", BirthDate = new DateTime(2002, 6, 10), PhoneNumber = "890-123-456", HomeAddress = "890 Apricot St", Rating = GradeRating.C });
--list.Add(new StudentModel() { StudentId = 19, FirstName = "Quinn", LastName = "Martinez", Age = 23, PeselNumber = "90123456789", BirthDate = new DateTime(2000, 7, 15), PhoneNumber = "901-234-567", HomeAddress = "901 Nectarine St", Rating = GradeRating.A });
--list.Add(new StudentModel() { StudentId = 20, FirstName = "Rachel", LastName = "Lopez", Age = 19, PeselNumber = "01234567890", BirthDate = new DateTime(2004, 8, 20), PhoneNumber = "012-345-678", HomeAddress = "012 Tangerine St", Rating = GradeRating.B });

--connection.BulkInsert(list);
