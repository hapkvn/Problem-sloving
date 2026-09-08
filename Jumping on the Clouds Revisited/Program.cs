using System;

class Program
{
    public static void Main()
    {
        int nerverUse = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int sum = 0;
        int temp = 0;
        for(int i = 0; i<arr.Length; i++)
        {
            if(arr[i] == 0)
            {
                sum++;
                temp++;
            }
            if(arr[i] == 1 )
            {
                temp=0;

            }
            if (temp == 3)
            {
                sum--;
                temp = 1;
            }
        }
        Console.WriteLine(sum-1);
    }
}