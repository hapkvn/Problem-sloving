using System;

class Program
{
    public static void Main()
    {
        string sos = Console.ReadLine();
        string idea_sos = "SOS";
        int sum=0;
        for(int i=0; i<sos.Length; i ++)
        {
            
                if(sos[i] !=idea_sos[i%3])
                {
                    sum++;
                }
            
        }
        Console.WriteLine(sum);
    }
}