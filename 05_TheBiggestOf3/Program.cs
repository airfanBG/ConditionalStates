using System;
  class Program
    {
        static void Main()
        {
            Console.WriteLine("Write \"a\"");
            double a, b, c;
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Write \"b\"");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Write \"c\"");
            double.TryParse(Console.ReadLine(), out c);
            

                if (((a>=b)&&(a>=c))&&((a<=0)||(a>=0)))
                    {
                        Console.WriteLine("Bigesst is \"a\"{0}",a); 
                    }
                    else if (((a<=b)&&(b>c))&&((b<=0)||(b>=0)))
                        {
                            Console.WriteLine("Bigesst is \"b\"{0}", b);
                        }
                            else if (((a>=b)&&(b<c))&&((c<=0)||(c>=0)))
                                {
                                    Console.WriteLine("Bigesst is \"c\"{0}", c);
                                }
            

        }
    }

