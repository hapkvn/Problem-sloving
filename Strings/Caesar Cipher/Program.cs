using System;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string intput_string = Console.ReadLine();

        int step = int.Parse(Console.ReadLine());
        

        char[] arr = intput_string.ToArray();

        
            step %= 26;
        

        for(int i=0; i<n; i++)
        {
            int temp = arr[i];
            if(temp<='Z' &&temp>='A')
            {
                temp += step;
                
                if(temp > 'Z')  temp-= 26;
                arr[i] = (char)temp;
            }
            else if(temp<='z' && temp >= 'a')
            {
                temp += step;
                
                if(temp > 'z') temp -= 26;
                arr[i] = (char)temp;              
                
            }

        }

        Console.WriteLine(new string(arr));


    }
}