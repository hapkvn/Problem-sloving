using System;
class Program
{
    public static void Main()
    {
        

        string input_string = Console.ReadLine().ToLower();

        int [] abc = new int[27];


        foreach(char c in input_string)
        {
            if(c>= 'a' && c<='z')
            {
               int temp = c-'a';
               abc[temp]++;
            }
            if(c == ' ')
            {
                abc[26]++;
            }
        }

        if (abc.Min() > 0)
        {
            Console.WriteLine("pangram");
        }
        else
        {
            Console.WriteLine("not pangram");
        }
    }
}