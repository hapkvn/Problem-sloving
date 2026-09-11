using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

class Program
{
    public static void Main()
    {
        int[] n_input =  Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int n = n_input[0];
        int k = n_input[1];

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int sum = 0;
        int ensery = 100;
        int current = 0;

        while (true)
        {
            current = (current + k) % n;

            if(arr[current] == 1)
            {
                ensery-=3;
            }
            else
            {
                ensery--;
            }

            if(current == 0)
            {
                break;
            }
        }
        

        Console.WriteLine(ensery);
    }
}