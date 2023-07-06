using System;
using System.Globalization;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string date;
            Console.WriteLine("Enter date: ");
            date = Console.ReadLine();
            try
            {
                DateTime dt = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
