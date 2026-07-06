using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for(int i=0; i<n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            
        }
        for(int i=0; i<n; i++)
        {
            int temp = 1;
            if(arr[i] == 0)
            {
                Console.WriteLine(temp);
            }            
            else
            {
                for(int j=0; j < arr[i]; j++)
                {
                    if (j % 2 != 0)
                    {
                        temp++;
                    }
                    else
                    {
                        temp *=2;                        
                    }
                }
                Console.WriteLine(temp);
                
            }
        }
        

    }
}