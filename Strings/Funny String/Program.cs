using System;
class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] arr_string = new string[n];
        for(int i=0; i<n; i++)
        {
            arr_string[i] = Console.ReadLine();
        }

        for(int i=0; i<n; i++)
        {
            char[] arr_char = arr_string[i].ToCharArray();
            int[] asciiArray = arr_char.Select(c => (int)c).ToArray();
            int[] funny = new int[asciiArray.Length-1];

            for(int j = 1; j< arr_char.Length; j++)
            {
                funny[j-1] = Math.Abs( asciiArray[j] - asciiArray[j-1]);
            }

            int[] check = funny.Reverse().ToArray();
            bool result = true;
            for(int j=0; j< check.Length; j++)
            {
                if(check[j] == funny[j])
                {
                    result = true;
                }
                else
                {
                    result = false;                    
                    break;
                }
                



            }
            if(result == true)
            {
                Console.WriteLine("Funny");
            }
            else
            {
                Console.WriteLine("Not Funny");
            }
               
            
        }
    }
}