using System;

class Program
{
    static void Main()
    {
        string input_s = Console.ReadLine();

        char[] char_s = input_s.ToCharArray();
        int sum =1;
        foreach(char cs in char_s)
        {
            if (char.IsUpper(cs) == true)
            {
                sum++;
            }
        }
        Console.WriteLine(sum);
    }
}