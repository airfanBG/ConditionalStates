using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write \"a\"");
            double a,b,c;
            double.TryParse(Console.ReadLine(),out a);
            Console.WriteLine("Write \"b\"");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Write \"c\"");
            double.TryParse(Console.ReadLine(), out c);
            if ((a>0&&b>0&&c>0)||(a<0&&b<0&&c>0)||(a<0&&b>0&&c<0)||(a>0&&b<0&&c<0))
            {
                Console.WriteLine("Result: +"); 
            }
                
                else if ((a==0)||(c==0)||(b==0))
                {
                    Console.WriteLine("Result: 0");
                    
                }
                 else
                        {
                            Console.WriteLine("Result: -");
                        }
        }
    }

