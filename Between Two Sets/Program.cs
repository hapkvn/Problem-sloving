using System;
using System.Linq;

class Program
{
    public static void Main()
    {
        Console.ReadLine(); 
        
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        

        int lcm_A = GetLcmOfArray(a);
        int gcd_B = GetdmcOfArray(b);
        int count = 0;

        for(int i = lcm_A; i<=gcd_B; i+=lcm_A)
        {
            if(gcd_B % i == 0)
            {
                count++;
            }
        }        

        Console.WriteLine(count);
    }

    static int GetLcmOfArray(int[] arr)
    {
        int result = arr[0];

        for(int i=1; i< arr.Length; i++)
        {
            result = getLCM(result, arr[i]);
        }
        return result;
    }

    static int GetdmcOfArray(int[] arr)
    {
        int result = arr[0];
        for(int i=1; i<arr.Length; i++)
        {
            result = GetGCD(result, arr[i]);
        }
        return result;
    }
    
    static int GetGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp =b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int getLCM(int a, int b)
    {
        return (a / GetGCD(a, b)) * b;
    }
}