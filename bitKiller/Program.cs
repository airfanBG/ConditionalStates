using System;

class Program
{
    static void Main()
    {
        int number = 87;
        
        int step =11;
        
        
        int index = 0;
        for (int i = 0; i < 1; i++)
        {
            for (int bit = 7; bit >= 0; bit--)
            {

                if (index%step == 1)
                {
                    number = number |(bit>>1);
                }
                index++;
            }
            Console.WriteLine(Convert.ToString(number,2).PadLeft(16,'0'));
            
            Console.WriteLine(Convert.ToString(number,2).PadLeft(16,'0'));
            Console.WriteLine(number);
        }
    }
}
