using System;

class Program
{
    static void InsertSort(int[] array)
    {
        int n = array.Length;
        int temp;

        for (int i = 1; i < n; i++)
        { 
            for (int j=i; j>0; j--)
            {             
                if (array[j-1] > array[j])
                {
                    temp = array[j];
                    array[j] = array[j-1];
                    array[j-1] = temp;
                }
            }
        }
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

        InsertSort(array);

        Console.WriteLine("TABLICA PO SORTOWANIU: ");
        PrintArray(array);

    }
}
