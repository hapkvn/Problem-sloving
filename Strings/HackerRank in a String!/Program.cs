using System;

class Program
{
    public static void Main()
    {
        int q = int.Parse(Console.ReadLine());
        string target = "hackerrank";
        
        for(int k = 0; k < q; k++)
        {
            string s = Console.ReadLine();
            
            int j = 0; 
            
            for(int i = 0; i < s.Length; i++)
            {
                if(j < target.Length && s[i] == target[j])
                {
                    j++; 
                }
            }
            
            if(j == target.Length)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}