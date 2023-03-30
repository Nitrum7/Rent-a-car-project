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

        public static List<string> carBrands = new List<string> { "Toyota", "Honda", "Ford", "Chevrolet", "Nissan", "Jeep", "Dodge", "BMW", "Mercedes-Benz", "Audi", "Hyundai", "Kia", "Volvo", "Mazda", "Subaru", "Volkswagen", "Lexus", "Cadillac", "GMC", "Chrysler" };
        public static List<string> carModels = new List<string> { "Camry", "Accord", "Mustang", "Corvette", "Altima", "Wrangler", "Challenger", "3 Series", "C-Class", "A4", "Elantra", "Optima", "S60", "CX-5", "Outback", "Golf", "RX", "Escalade", "Sierra", "300" };
        public static List<int> carSeats = new List<int> { 2, 4, 5, 6, 7 };
 
        public static DateTime start = new DateTime(2004, 1, 1);
        public const string Password = "123456";

        public const string AdminEmail = "admin@abv.bg";
        public const string AdminFirstName = "Admin";
        public const string AdminLastName = "Admin";
        public static string username = "{0}{1}{2}@{3}";
    }
}
