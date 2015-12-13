using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter \"a\":");
        double a = 0;
        double.TryParse(Console.ReadLine(), out a);
        Console.WriteLine("Enter \"b\":");
        double b = 0;
        double.TryParse(Console.ReadLine(), out b);

        if (b > a)
        {
            Console.WriteLine("a={1} b={0}", a, b);
        }
        else
        {
            Console.WriteLine("a={0} b={1}", a, b);
        }
    }
}

