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
        int max=0;
       
        for(int i=0; i<100; i++)
        {
           int temp =  temp_arr[i+1] + temp_arr[i];

            max = Math.Max(max, temp);
            
            
        }
        Console.WriteLine(max);
       

    }   
}