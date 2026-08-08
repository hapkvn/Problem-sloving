using System;

class Program
{
    static void Main()
    {
        int never_use = int.Parse(Console.ReadLine());
        int[] main_array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] d_m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int d = d_m[0];
        int m = d_m[1];

        int result = 0;
        for(int i=0; i<= never_use - m ; i++)
        {
            int temp=0;
            for(int j=0; j< m; j++)
            {
                temp +=main_array[j+i];
            }
            if( temp == d)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}