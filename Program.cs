using System;

namespace StringCFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Jon Cena";
            Console.WriteLine("Trim: '{0}'", fullName.Trim()); // Trim: 'Jon Cena'

            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper()); // Trim: 'JON CENA'

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstNa me: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Jon", "Cena"));

            if (String.IsNullOrWhiteSpace(" "))
            Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C")); //$29.95

            Console.WriteLine(price.ToString("C0")); //adding the zero after makes it output $30

        }
    }
}
