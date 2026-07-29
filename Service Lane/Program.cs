using System;

class Program
{
    static void Main()
    {
        int[] arrInput = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] arrHW = Array.ConvertAll(Console.ReadLine(). Split(' '), int.Parse);

        List<int[]> vehicles = new List<int[]>();

        for(int i=0; i< arrInput[1];i++){
            int[] veArr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            vehicles.Add(veArr);
        }

        foreach(int[] vehicle in vehicles)
        {
            int begin  = vehicle[0];
            int end = vehicle[1];
            int min =3;
            for(int i=begin; i <= end; i++)
            {
                if (arrHW[i] < min)
                {
                    min = arrHW[i];
                }
            }
            Console.WriteLine(min);
            min =3;
        }



    }
}