    using System;
    using System.Collections.Generic;


    class Program
    {
        public static void Main()
        {
            string s = Console.ReadLine();

            List<char> stack = new List<char>();   

            foreach(char c in s)
            {
                if(stack.Count >0 && stack[stack.Count -1] == c)
                {
                stack.RemoveAt(stack.Count -1);
                }
                else
                {
                    stack.Add(c);
                }
            }

            if(stack.Count == 0)
            {
                Console.WriteLine("Empty String");
            }
            else
            {
                Console.WriteLine(new String(stack.ToArray()));
            }

        }
    }