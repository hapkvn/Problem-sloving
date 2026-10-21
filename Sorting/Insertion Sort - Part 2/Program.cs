using System;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        for(int i = 1; i<n; i++)
        {
            int temp = arr[i];

            int j = i - 1;

            while(j>=0 && arr[j] > temp)
            {
                arr[j+1] = arr[j];
                j--;
            }

            arr[j+1] = temp;


        }
        Console.Write(arr + " ");
    }
}