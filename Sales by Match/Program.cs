using System;
class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int[] temp_arr = new int[101];

        foreach(int ar in arr)
        {
            temp_arr[ar]++;
        }

        
        int sum =0;

        for(int i=0; i<temp_arr.Length; i++)
        {
            temp_arr[i] = temp_arr[i]/2;
        }
        for(int i=0; i<temp_arr.Length; i++)
        {
            
            sum += temp_arr[i];
        }
    

        Console.WriteLine(sum);

    }
}