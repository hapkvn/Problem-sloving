using System;

class Program
{
    public static void Main()
    {
        int neverUse = int.Parse(Console.ReadLine());
        string[] arr = new string[neverUse];

        for(int i =0; i< neverUse; i++)
        {
            arr[i] = Console.ReadLine();
        }
        int[] arr_sum = new int[neverUse];

        for(int i=0; i<neverUse; i++)
        {
            int sum = 0;

            char[] char_arr = arr[i].ToCharArray();
            char temp = char_arr[0];

            for(int j = 0; j<char_arr.Length; j++)
            {
                if(char_arr[j] != null && char_arr[j] == temp)
                {
                    sum++;
                }
                temp = char_arr[j];
            }
            arr_sum[i] = sum-1; 
        }

        for(int i=0; i< neverUse; i++)
        {
            Console.WriteLine(arr_sum[i]);
        }
    }
}