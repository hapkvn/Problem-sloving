using System;
using System.Net.Mail;
using System.Linq;
class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        

        int[] temp_arr = new int[6];

        foreach(int ar in arr)
        {
            temp_arr[ar]++;
        }

        int max = temp_arr.Max();
        for(int i=1; i<=5; i++)
        {
            if (temp_arr[i] == max)
            {
                Console.WriteLine(i);
                break;
            }
        }
        
    }
}