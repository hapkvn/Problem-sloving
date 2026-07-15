using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];

        for(int i=0; i<n; i++)
        {
             arr[i] = Console.ReadLine();
        }

        for(int i=0; i<n; i++)
        {
            char[] charr = arr[i].ToCharArray();

            int temp_arr = int.Parse(arr[i]);
            int sum =0;


            for(int j=0; j<charr.Length; j++)
            {
                int temp = charr[j] - '0';

                if (temp != 0)
                {
                    if(temp_arr % temp == 0)
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine(sum);
        }

    }
}