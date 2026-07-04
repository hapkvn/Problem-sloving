class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        String input_number = Console.ReadLine();
        string[] number =  input_number.Split(' ');

        int max = int.Parse(number[0]);
        int min = int.Parse(number[0]);
        int count_max = 0;
        int count_min = 0;

        for(int i=0; i<n; i++)
        {
            if(int.Parse(number[i]) > max)
            {
                max = int.Parse(number[i]);
                count_max++;
            }
            if(int.Parse(number[i])< min)
            {
                min = int.Parse(number[i]);
                count_min++;
            }

        }

        Console.WriteLine(count_max + " " + count_min );

    }
}