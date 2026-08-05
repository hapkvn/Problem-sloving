using System;

class Program
{
    static void Main()
    {
        int never_use = int.Parse(Console.ReadLine()); 
        string steps = Console.ReadLine();

        int altitude = 0; 
        int valleys = 0;  

        foreach (char step in steps)
        {
            if (step == 'U')
            {
                altitude++;
                
      
                if (altitude == 0)
                {
                    valleys++;
                }
            }
            else if (step == 'D')
            {
                altitude--;
            }
        }

        Console.WriteLine(valleys);
    }
}