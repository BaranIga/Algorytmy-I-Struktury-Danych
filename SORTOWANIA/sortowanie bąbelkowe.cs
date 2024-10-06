using System;

class Program
{
    static void Sort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("TABLICA PRZED SORTOWANIEM: ");
        PrintArray(array);
        Console.WriteLine();

        Sort(array);

        Console.WriteLine("TABLICA PO SORTOWANIU: ");
        PrintArray(array);

    }
}
