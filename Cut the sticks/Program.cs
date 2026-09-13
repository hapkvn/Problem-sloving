using System;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        List<int> sticks = arr.ToList();

        while (sticks.Count >0)
        {            
            Console.WriteLine(sticks.Count);

            int MinStick = sticks.Min();
            
                for(int i=0; i<sticks.Count; i++)
                {
                    sticks[i] -= MinStick;
                }
            sticks.RemoveAll(x => x <= 0);
            
        }
        
    }
}