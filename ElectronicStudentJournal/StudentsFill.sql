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