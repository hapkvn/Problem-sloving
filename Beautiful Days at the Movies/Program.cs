using System;

class Program
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int beautiful_day = 0;
        int k = arr[2];
        int begin = arr[0];
        int end = arr[1];
        
        for(int i=begin; i<=end; i++)
        {
            int orginal = i;
            int reversed = 0;

            while (orginal > 0)
            {
                reversed = reversed*10 +(orginal%10);
                orginal/=10;
            }

            if ((i-reversed) % k == 0)
            {
                beautiful_day++;
            }
        }
        Console.WriteLine(beautiful_day);
    }
}