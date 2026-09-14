using System;

class Program
{
    public static void Main()
    {
        int[] arr_or = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse );
        int[] key = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] desk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int max_Price = arr_or[0];
        int[] arr_price = new int[key.Length +desk.Length];
        List<int> list = arr_price.ToList();
        int max =0;

        for(int i=0; i<key.Length; i++)
        {
            for(int j=0; j<desk.Length; j++)
            {
                list[i+j] = key[i]+desk[j];

                if(list[i+j]>=max && list[i+j]<= max_Price)
                {
                    max = list[i+j];
                }
            }

        }
    

        if(max == 0 )
        {
            Console.WriteLine("-1");
        }
        else
        {
            Console.WriteLine(max);
        }
        
    }
}