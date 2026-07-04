using System;

class Program
{
    static void Main()
    {

        String input_home = Console.ReadLine();
        string[] home = input_home.Split(' ');
        int left_home = int.Parse(home[0]);
        int right_home = int.Parse(home[1]);
        

        String input_tree = Console.ReadLine();
        string[] tree = input_tree.Split(' ');
        int apple = int.Parse(tree[0]);
        int orange = int.Parse(tree[1]);


        String input_fall_number = Console.ReadLine();
        string[] fruit = input_fall_number.Split(' ');

        int apple_count = int.Parse(fruit[0]);
        int orange_count = int.Parse(fruit[1]); 

        int apple_fall_count = 0;
        String input_apples = Console.ReadLine();
        string[] apples_str = input_apples.Split(' ');
        int[] apples = new int[apple_count];
        
        for(int i = 0; i < apple_count; i++)
        {
            apples[i] = int.Parse(apples_str[i]);
            int position = apple + apples[i]; 
            
            if(position >= left_home && position <= right_home)
            {
                apple_fall_count++;
            }
        }


        int orange_fall_count = 0;
        String input_oranges = Console.ReadLine();
        string[] oranges_str = input_oranges.Split(' ');
        int[] oranges = new int[orange_count];
        
        for(int i = 0; i < orange_count; i++)
        {
            oranges[i] = int.Parse(oranges_str[i]);
            int position = orange + oranges[i];
            
  
            if(position >= left_home && position <= right_home)
            {
                orange_fall_count++;
            }
        }
        

        Console.WriteLine(apple_fall_count);
        Console.WriteLine(orange_fall_count);
    }
}