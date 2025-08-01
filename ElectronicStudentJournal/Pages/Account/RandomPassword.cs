using System;

namespace ElectronicStudentJournal.Pages.Account
{
    public class RandomPassword
    {
        public static string RandomPass(int passLength = 15)
        {
            string password = string.Empty;
            string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+[]{}|;:,.<>?";
            for(int i = 0; i < passLength; i++)
            {
                int index = new Random().Next(0, validChars.Length-1);
                password += validChars[index];
            }
            return password;
        }
    }
}
