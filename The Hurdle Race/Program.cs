using System;

class Program
{
    static void Main()
    {
        int[] input_number = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int max_high = input_number[1];

        int[] input_objects = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int temp=0;
        int increace_high = 0;
        for(int i=0; i<input_objects.Length; i++)
        {
            if (input_objects[i] > max_high)
            {
                temp = input_objects[i] - max_high;
                if(temp>= increace_high)
                {
                    increace_high = temp;
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }

        Console.WriteLine(increace_high);
    }
}