using System;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());       
        

        int begin = p/2;

        int end = n/2;

        int form_end = end-begin;

        if(form_end>= begin)
        {
            Console.WriteLine(begin);
        }
        else
        {
         Console.WriteLine(form_end);
  
        }

    }
}