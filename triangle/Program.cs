using System;



    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write coordinates for point \"A\", first \"X\"");
            int Ax = int.Parse(Console.ReadLine());
            Console.WriteLine("Write coordinates for point \"A\", second \"Y\"");
            int Ay = int.Parse(Console.ReadLine());
            Console.WriteLine("Write coordinates for point \"B\", first \"X\"");
            int Bx = int.Parse(Console.ReadLine());
            Console.WriteLine("Write coordinates for point \"B\", second \"Y\"");
            int By = int.Parse(Console.ReadLine());
            Console.WriteLine("Write coordinates for point \"C\", first \"X\"");
            int Cx = int.Parse(Console.ReadLine());
            Console.WriteLine("Write coordinates for point \"C\", second \"Y\"");
            int Cy = int.Parse(Console.ReadLine());
            double a= Math.Sqrt(Math.Pow((Cx - Bx), 2) + Math.Pow((Cy - By),2));
            double b = Math.Sqrt(Math.Pow((Ax - Cx), 2) + Math.Pow((Ay - Cy), 2));
            double c = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2));

            double halfPerimeter=(a+b+c)/2;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            if ((a+b>c)&&(b+c>a)&&(c+a>b))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0:F2}",Math.Sqrt(halfPerimeter*(halfPerimeter-a)*(halfPerimeter-b)*(halfPerimeter-c)));
            }
            else
            {
                Console.WriteLine("NO");
                Console.WriteLine("{0:F2}",c);
            }
        }
    }

