using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] number = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
        int[] dm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int d = dm[0];
        int m = dm[1];
        int kq=0;
        for(int i=0; i<= n-m; i++)
        {
            int temp=0;
            for(int j=0; j<m; j++)
            {
                    temp += number[i+j];                   
            }
            if(temp == d)
            {
                kq++;
            }
        }
        Console.WriteLine(kq);
    }
}