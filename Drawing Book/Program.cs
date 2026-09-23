using System;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());       
        

        int begin = p/2;

        int end = n/2 - p/2;


        Console.WriteLine(Math.Min(begin, end));

    }
}