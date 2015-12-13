using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Write \"a\"");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Write \"b\"");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Write \"c\"");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Write \"d\"");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Write \"e\"");
        int e = int.Parse(Console.ReadLine());
        int sum = 0;
        if (a + b + c + d + e == 0)
        {
            sum = a + b + c + d + e;
            Console.WriteLine("{0} {1} {2} {3} {4} = {5}", a, b, c, d, e,sum);
        }
        if (a + c + d + e == 0)
        {
            sum = a + c + d + e;

            Console.WriteLine("{0} {1} {2} {3} ={4}", a, c, d, e,sum);
        }
        if (a + b + d + e == 0)
        {
            sum = a + b + d + e;
            Console.WriteLine("{0} {1} {2} {3} ={4}", a, b, d, e,sum);
        }
        if (a + b + c + e == 0)
        {
            sum = a + b + c + e;
            Console.WriteLine("{0} {1} {2} {3} = {4}", a, b, c, e,sum);
        }
        if (a + b + c + d == 0)
        {
            sum = a + b + c + d;

            Console.WriteLine("{0} {1} {2} {3}={4}", a, b, c, d,sum);
        }
        if (b + c + d + e == 0)
        {
            sum = b + c + d + e;

            Console.WriteLine("{0} {1} {2} {3}{4}", b, c, d, e,sum);
        }
        if (a + b + c == 0)
        {
            sum = a + b + c;
            Console.WriteLine("{0} {1} {2} = {3}", a, b, c, sum);
        }
        if (a + c + d == 0)
        {
            sum = a + c + d;

            Console.WriteLine("{0} {1} {2} ={3}", a, c, d, sum);
        }
        if (a + d + e == 0)
        {
            sum = a + d + e;

            Console.WriteLine("{0} {1} {2} ={3}", a, d, e, sum);
        }
        if (a + b + e == 0)
        {
            sum = a + b + e;
            Console.WriteLine("{0} {1} {2} ={3}", a, b, e, sum);
        }
        if (a + b + d == 0)
        {
            sum = a + b + d;
            Console.WriteLine("{0} {1} {2}={3}", a, b, d, sum);
        }
        if (b + c + d == 0)
        {
            sum = b + c + d;
            Console.WriteLine("{0} {1} {2} ={3}", b, c, d, sum);
        }
        if (b + d + e == 0)
        {
            sum = b + d + e;

            Console.WriteLine("{0} {1} {2} = {3}", b, d, e, sum);
        }
        if (c + d + e == 0)
        {
            sum = c + d + e;

            Console.WriteLine("{0} {1} {2} ={3}", c, d, e, sum);
        }
        if (c + b + e == 0)
        {
            sum = c + b + e;

            Console.WriteLine("{0} {1} {2}={3}", c, b, e, sum);
        }

        if (a + b == 0)
        {
            sum = a + b;
            Console.WriteLine("{0} {1} {2}", a, b, sum);
        }
        if (b + c == 0)
        {
            sum = b + c;

            Console.WriteLine("{0} {1} ={2}", b, c, sum);
        }
        if (c + d == 0)
        {
            sum= c+d;
            Console.WriteLine("{0} {1} ={2}", c, d, sum);
        }
        if (d + e == 0)
        {
            sum = d + e;

            Console.WriteLine("{0} {1} ={2}", d, e, sum);
        }
        
        if (a + c == 0)
        {
            sum = a + c;

            Console.WriteLine("{0} {1} ={2}", a, c, sum);
        }
        if (a + d == 0)
        {
            sum = a + d;

            Console.WriteLine("{0} {1} ={2}", a, d, sum);
        }
        if (a + e == 0)
        {
            sum = a + e;

            Console.WriteLine("{0} {1} ={2}", a, e, sum);
        }

        else
        {
            Console.WriteLine("No zero subset");
        }
        
    }
}
    