using System;
class Program
{
    static void Main()
    {
        int[] Anna = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int k = Anna[1];
        int[] bill = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
        int b = int.Parse( Console.ReadLine());
        int count =0;
        for(int i=0; i< bill.Length; i++)
        {
            count += bill[i];
        }
        int Brian_bill = count/2;

        int Anna_bill = (count - bill[k])/2;

        if(Anna_bill >= b)
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            Console.WriteLine(Brian_bill - Anna_bill);
        }


    }
}