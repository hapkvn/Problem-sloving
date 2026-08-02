using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        int arrInput = int.Parse(Console.ReadLine());
        string[] result = new string[arrInput];

        
        for(int i=0; i< arrInput; i++)
        {
            int sNO =0;
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int Professor = input[1];
            int student = input[0];
            int[] stu = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for(int j=0; j< student; j++)
            {
                if (stu[j] <= 0)
                {
                   sNO++; 
                }
            }
            if(sNO <Professor)
            {
                result[i] = "YES";
            }
            else
            {
               result[i] = "NO";

            }

        }
        for(int i=0; i<arrInput; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}