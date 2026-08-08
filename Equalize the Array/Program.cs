using System;

class Program
{
    static void Main()
    {
        int never_use = int.Parse(Console.ReadLine());
        int[] main_arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] temp_arr = new int[101];
        foreach(int num in main_arr)
        {
            temp_arr[num]++;

        }
        int max = temp_arr.Max();
        
        Console.WriteLine(never_use - max);
    }
}