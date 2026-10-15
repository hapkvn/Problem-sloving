using System;

class InsertionSortExample
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        PrintArray(arr);
        
        InsertionSort(arr);
        
        PrintArray(arr);
    }

    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            
            arr[j + 1] = key;

            PrintArray(arr);
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}