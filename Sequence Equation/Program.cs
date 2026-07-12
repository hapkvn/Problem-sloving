using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] arr = new int[input+1];
        for(int i=0; i<input; i++)
        {        
            
            int temp = n[i];

            int read_pos = i+1;

            arr[temp] = read_pos;
        }

        for(int i=1; i<= input; i++)
        {
            int pos = arr[i];
            int y = arr[pos];
            Console.WriteLine(y);
        }
    }
}