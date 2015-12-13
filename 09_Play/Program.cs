using System;
  class Program
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1--> int");
            Console.WriteLine("2--> double");
            Console.WriteLine("3--> string");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter a number:");
                    int number1 = int.Parse(Console.ReadLine());
                    number1 = number1 + 1;
                    Console.WriteLine("Result:{0}", number1);
                    break;
                case 2:
                    Console.WriteLine("Please enter a number:");
                    double number2 = double.Parse(Console.ReadLine());
                    number2 = number2 + 1;
                    Console.WriteLine("Result:{0}", number2);
                    break;
                case 3:
                    Console.WriteLine("Please enter a word:");
                    string word = Console.ReadLine();
                    Console.WriteLine(word+"*");
                    break;
                default:
                    Console.WriteLine("Not valid choice");
                    break;
            }
        }
    }

