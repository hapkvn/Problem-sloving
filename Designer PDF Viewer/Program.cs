using System;

class Program
{
    static void Main()
    {
        int[] arr_num_word = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        string word = Console.ReadLine();

        int max = 0;

        foreach( char c in word)
        {
            int temp = c - 'a';

            temp = arr_num_word[temp];

            max = Math.Max(max, temp);
        }
       
        Console.WriteLine(max* word.Length);


    }
}