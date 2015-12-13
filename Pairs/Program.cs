using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int index = 0;
            int sum = 0;
            if (n%2!=0)
            {
                Console.WriteLine("Not even numbers");
            }
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += n;
                
            }
            Console.WriteLine(sum);
            if ((sum%(n/2))==0)
            {
                Console.WriteLine(sum/2);
            }
            
        }
    }
