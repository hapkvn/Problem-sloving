using System;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string intput_string = Console.ReadLine();

        int step = int.Parse(Console.ReadLine());
        

        char[] arr = intput_string.ToArray();

        while(step > 26)
        {
            step -= 26;
        }

        for(int i=0; i<n; i++)
        {
            int temp = arr[i];
            if(temp<=90 &&temp>=65)
            {
                temp += step;
                
                if(temp > 90)
                {
                    temp = temp - 26;
                    arr[i] = (char)temp;

                }
                else
                {
                    arr[i] = (char)temp;
                }
                
            }
            if(temp<=122 && temp >= 97)
            {
                temp += step;
                
                if(temp > 122)
                {
                    temp = temp - 26;
                    arr[i] = (char)temp;

                }
                else
                {
                    arr[i] = (char)temp;
                }
            }

        }

        Console.WriteLine(new string(arr));


    }
}