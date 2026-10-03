using System;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int end = arr[n-1];

        for(int i=n-2; i>=0; i--)
        {
            if(end<=arr[i])
            {
                arr[i+1] = arr[i];
                Console.WriteLine(string.Join(" ", arr));
                arr[i] = end;
            }

        }

                Console.WriteLine(string.Join(" ", arr));
    }
}