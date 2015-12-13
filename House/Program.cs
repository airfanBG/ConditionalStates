using System;

    class Program
    {
        static void Main()
        {
            //string star = "*";
            //string point = ".";
            for (int i = 1; i <= 5; i++)
            {
                int index = 0;
                string point = new string('.', 5/2);
                string starRoof = new string('*', 5-4);

                if (i==1)
                {
                    Console.WriteLine("{0}{1}{0}", point, starRoof);
                }
                index++;
                }
            }
            
        }
    

