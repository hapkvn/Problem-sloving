using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input_number = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int max_high = input_number[1];

        int[] input_objects = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
       int hurdle = input_objects.Max();

       int poition_needed = hurdle > max_high ? hurdle - max_high : 0;

        Console.WriteLine(poition_needed);
    }
}