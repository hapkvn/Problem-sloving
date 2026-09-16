using System;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] sArr = new string[n];
        int[] result = new int[n];

        for(int i=0; i<n; i++)
        {
            sArr[i] = Console.ReadLine();
        }
        for(int i=0; i<n; i++)
        {
            char[] temp_char = sArr[i].ToCharArray();
            for(int j=0; j< temp_char.Length/2; j++)
            {
                if(temp_char[j] != temp_char[temp_char.Length - 1 - j])
                {
                    result[i]+= Math.Abs(temp_char[j] - temp_char[ temp_char.Length-1-j]);
                }
               

            }
            Console.WriteLine(result[i]);
        }
        


    }
}