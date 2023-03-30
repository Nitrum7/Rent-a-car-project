namespace RentACar.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class SeederConstants
    {
        public static List<string> firstNames = new List<string>() { "Alex", "Kiro", "Nikolay", "Nasko", "Pepi", "Valeria", "Maria","Monica","Kristian","Ivan" };
        public static List<string> lastNames = new List<string>() { "Alexandrov", "Johnson", "Ivanov", "Petrov", "Vodev","Totev","Botev","Tsanov","Paleykov"};
        public static List<string> mails = new List<string>() { "mail.bg", "abv.bg", "live.com", "gmail.com", "mail.ru", "outlook.com" };

        public const string Password = "123456";

        public const string AdminEmail = "admin@abv.bg";
        public const string AdminFirstName = "Admin";
        public const string AdminLastName = "Admin";
        public static string username = "{0}{1}{2}@{3}";
    }
}
