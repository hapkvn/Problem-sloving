using System;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long[] result = new long[n];
        for(int i=0; i< n; i++)
        {
           long [] arr = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);     

            long p = arr[0]; 
            long m = arr[1]; 
            long s = arr[2]; 

             result[i] = (s + m - 2) % p + 1;
        }

        for(int i=0; i< n; i++)
        {
            Console.WriteLine( result[i]);      
            
        }
    }
}