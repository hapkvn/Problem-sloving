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
        int max =-1;

        for(int i=0; i<key.Length; i++)
        {
            for(int j=0; j<desk.Length; j++)
            {
                int comobo = key[i]+desk[j];

                if(comobo>=max && comobo<= max_Price)
                {
                    max = comobo;
                }
            }

        }    
            Console.WriteLine(max);

        
    }
}