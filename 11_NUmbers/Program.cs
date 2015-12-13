using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insert a number from 0 to 999");
        int n;
        int.TryParse(Console.ReadLine(), out n);
        string[] zeroToNineteen = {"zero","one","two","three",
        "four","five", "six","seven","eight","nine","ten",
        "eleven","twelve","thirteen","fourteen","fifteen", 
        "sixteen","seventeen","eighteen" ,"nineteen"};

        string[] wordToHundred = {string.Empty,string.Empty,
        "twenty","thirty","forty","fifty","sixty","seventy",
        "eighty","ninety"};

        
        if (n >= 0 && n < 20)
        {
            Console.WriteLine("{0}", zeroToNineteen[n]);
        }
        if (((n >= 20) && (n < 99)) && ((n % 10 == 0)))
        {
            Console.WriteLine("{0}", wordToHundred[n / 10]);
        }
        else if ((((n >= 20) && (n < 99)) && ((n % 10 != 0))))
        {
            Console.WriteLine("{0} {1}", wordToHundred[n / 10],zeroToNineteen[n%10]);
        }
        
        if ((n % 100 == 0) && (n != 0))
        {
            Console.WriteLine("{0} hundred", zeroToNineteen[n / 100]);
        }
        
        else if (((n >= 100) && (n < 1000)) && ((n % 10 == 0)))
        {
            Console.WriteLine("{0} hundred and {1}", zeroToNineteen[(n / 10) / 10], wordToHundred[(n / 10) % 10]);
        }
        else if (((n >= 100) && (n < 1000)) && ((n % 10 != 0)))
        {
            Console.WriteLine("{0} hundred and {1} {2}", zeroToNineteen[(n / 10) / 10], wordToHundred[(n / 10) % 10], zeroToNineteen[(n % 10)]);
        }

          
    }
      
}
    
  

