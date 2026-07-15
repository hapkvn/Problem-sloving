using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int[]> arrayM = new List<int[]>();
        for(int i=0; i<n; i++)
        {
            
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                arrayM.Add(arr);            
        }

        foreach(int[] arrM in arrayM)
        {
            int Cat_a = Math.Abs(arrM[2] - arrM[0]);
            int Cat_b = Math.Abs(arrM[2] - arrM[1]);

            if( Cat_a > Cat_b)
            {
                Console.WriteLine("Cat B");
            }
            else if( Cat_b > Cat_a)
            {
                Console.WriteLine("Cat A");
            }
            else
            {
                Console.WriteLine("Mouse C");
            }
            
        }
    }
}