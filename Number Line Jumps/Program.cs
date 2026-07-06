using System;

public class Program
{
    static void Main()
    {
        String input  = Console.ReadLine();
        string[] number = input.Split(' ');
        int x1 = int.Parse(number[0]);
        int v1 = int.Parse(number[1]);
        int x2 = int.Parse(number[2]);
        int v2 = int.Parse(number[3]);

        if(v1 > v2 && (x2 - x1) % (v1 - v2) == 0)
        {
             Console.WriteLine("YES");
        }
        else
        {           
            Console.WriteLine("NO");
        }
        
    }
}