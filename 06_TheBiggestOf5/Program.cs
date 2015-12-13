using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Write \"a\"");
        double a, b, c, d, e;
        double.TryParse(Console.ReadLine(), out a);
        Console.WriteLine("Write \"b\"");
        double.TryParse(Console.ReadLine(), out b);
        Console.WriteLine("Write \"c\"");
        double.TryParse(Console.ReadLine(), out c);
        Console.WriteLine("Write \"d\"");
        double.TryParse(Console.ReadLine(), out d);
        Console.WriteLine("Write \"e\"");
        double.TryParse(Console.ReadLine(), out e);
        
        if (((a > b) && (a > c) && (a > d) && (a >e)) && ((a <= 0) || (a >= 0)))
        {
            Console.WriteLine("Bigesst is \"a\"{0}", a);
        }
        else if (((b>a) && (b > c) && (b > d) && (b > e)))
        {
            Console.WriteLine("Bigesst is \"b\"{0}", b);
        }
        else if (((c > a) && (c > b) && (c > d) && (c > e)))
        {
            Console.WriteLine("Bigesst is \"c\"{0}", c);
        }
        else if (((d > a) && (d > b) && (d > c) && (d > e)))
        {
            Console.WriteLine("Bigesst is \"d\"{0}", d);
        }
        else if (((e > a) && (e > b) && (e > c) && (e >= d)))
        {
            Console.WriteLine("Bigesst is \"e\"{0}", e);
        }

    }
}

