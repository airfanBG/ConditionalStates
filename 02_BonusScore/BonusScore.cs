using System;

    class Program
    {
        static void Main()
        {
            int number = 0;
            int result = 0;
            Console.WriteLine("Write a number between 1 and 9:");
            int.TryParse(Console.ReadLine(), out number);
            switch (number)
            {
                case 1: result= number * 10;
                    Console.WriteLine(result);
                    break;
                case 2: result = number * 10;
                    Console.WriteLine(result);
                    break;
                case 3: result = number * 10;
                    Console.WriteLine(result);
                    break;
                case 4: result = number * 100;
                    Console.WriteLine(result);
                    break;
                case 5: result = number * 100;
                    Console.WriteLine(result);
                    break;
                case 6: result = number * 100;
                    Console.WriteLine(result);
                    break;
                case 7: result = number * 1000;
                    Console.WriteLine(result);
                    break;
                case 8: result = number * 1000;
                    Console.WriteLine(result);
                    break;
                case 9: result = number * 1000;
                    Console.WriteLine(result);
                    break;

                default:
                    Console.WriteLine("Not a valid number,try again");
                    break;
            }

        }
    }

