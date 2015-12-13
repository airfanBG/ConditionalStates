using System;
using System.Globalization;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write a time in format\"h:mm tt\"");
            string time = Console.ReadLine();
            string format = "h:mm tt";
            DateTime enterTime = DateTime.ParseExact(time, format, CultureInfo.InvariantCulture);
            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("2:59 AM");
            if (enterTime>=startTime||enterTime<=endTime)
            {
            Console.WriteLine("Beer time");        
            }
            else
	            {
                    Console.WriteLine("non beer time");
	            }
           
        }
    }

