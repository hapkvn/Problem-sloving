using System;

class Program
{
    static void Main()
    {
        int[] input_number = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int k = input_number[1];
        int n = input_number[0];
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse );
        int count =0;
        for(int i=0; i<n; i++)
        {
            for(int j=i; j< n; j++)
            {
            int temp =0;
                if(i != j)
                {
                    temp = arr[i] + arr[j];
                    if(temp % k == 0)
                    {
                        count ++;
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}