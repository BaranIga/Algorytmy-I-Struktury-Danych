using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(array, left, mid);
            MergeSort(array, right + 1, mid);
            Merge(array, left, mid, right);
        }
    }


    static void Merge(int[] array, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = array[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = array[mid + 1 + j];

        int index1 = 0, index2 = 0;

        int index = left;

        while (index1 < n1 && index2 < n2)
        {
            if (leftArray[index1] <= rightArray[index2])
            {
                array[index] = leftArray[index1];
                index1++;
            }
            else
            {
                array[index] = rightArray[index2];
                index2++;
            }
            index++;
        }

        while (index1 < n1)
        {
            array[index] = leftArray[index1];
            index1++;
            index++;
        }

        while (index2 < n2)
        {
            array[index] = rightArray[index2];
            index2++;
            index++;
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

        MergeSort(array, 0, array.Length - 1);

        Console.WriteLine("TABLICA PO SORTOWANIU: ");
        PrintArray(array);

    }
}
