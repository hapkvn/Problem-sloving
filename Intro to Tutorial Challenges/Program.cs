using System;
using System.Runtime.InteropServices;
class Program
{
    static void Main(){
        int n = int.Parse(Console.ReadLine());
        int nt = int.Parse(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        for(int i=0; i< arr.Length; i++)
        {
            if(n == arr[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}