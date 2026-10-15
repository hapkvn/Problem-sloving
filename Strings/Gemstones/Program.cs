using System;

class Program
{
    public static void Main()
    {  
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];

        IEnumerable<char> gems = Console.ReadLine();

        for(int i=1; i<n; i++)
        {
            string nextStone = Console.ReadLine();

            gems = gems.Intersect(nextStone);
        }

        Console.WriteLine(gems.Count());
    
    }
}