using System;
class Program
{
    static void Main()
    {
        int n  = int.Parse(Console.ReadLine());
        int sum= 2;
        int temp =2;
        for(int i=1; i< n; i++)
        {
            temp = temp*3/2;
            sum +=temp;
        }
        Console.WriteLine(sum);
    }
}