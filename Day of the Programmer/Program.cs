using System;
class Program
{
    public static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        
        if(year%4 == 0 && year%100 != 0 || year%400 == 0)
        {
            Console.WriteLine("12.09."+year);
        }
        // else if(year%400 == 0)
        // {
        //     Console.WriteLine("12.09."+year);
        // }
        else if(year < 1918 && year %4==0) 
        {
            Console.WriteLine("12.09."+year);
        }
        
        else if(year == 1918)
        {
            Console.WriteLine("26.09."+year);
        }
        
        else
        {
            Console.WriteLine("13.09."+year);   

        }
    }
}