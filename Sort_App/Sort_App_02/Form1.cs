using System.Collections;
using System.Diagnostics;

namespace Sort_App_02
{
    public partial class Form1 : Form
    {
        public int[] intArray;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;

            string[] stringArray = input.Split(',');

            try
            {
                intArray = Array.ConvertAll(stringArray, int.Parse);
                MessageBox.Show("Tablica intów: " + string.Join(", ", intArray)); 
            }
            catch (FormatException ex)
            {
                MessageBox.Show("B³¹d konwersji: " + ex.Message); 
            }

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            numericUpDown.Maximum = 1000;

            int count = (int)numericUpDown.Value;

            Random random = new Random();
            intArray = new int[count];

            try
            {
                for (int i = 0; i < count; i++)
                    intArray[i] = random.Next(1, 101); 
                MessageBox.Show("Tablica: " + string.Join(", ", intArray));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("B³¹d w genracji: " + ex.Message); 
            }
        }


        private void bubbleSort_Click(object sender, EventArgs e)
        {
            if (intArray == null)
            {
                MessageBox.Show("Najpierw dokonaj konwersji!");
                return; 
            }

            BubbleSortMethod(intArray); 

            textBoxOut.Text = "Posortowana tablica: " + string.Join(", ", intArray.Take(15));

        }

        private void insertSort_Click(object sender, EventArgs e)
        {
            if (intArray == null)
            {
                MessageBox.Show("Najpierw dokonaj konwersji!");
                return; 
            }

            InsertSortMethod(intArray); 

            textBoxOut.Text = "Posortowana tablica: " + string.Join(", ", intArray.Take(15));
        }

        private void mergeSort_Click(object sender, EventArgs e)
        {
            if (intArray == null || intArray.Length == 0)
            {
                textBoxOut.Text = "Najpierw przekonwertuj dane.";
                return;
            }

            int[] posortowane = MergeSortMethod(intArray);

            textBoxOut.Text = "Posortowana tablica: " + string.Join(", ", posortowane.Take(15));

        }

        private void quickSort_Click(object sender, EventArgs e)
        {
            if (intArray == null || intArray.Length == 0)
            {
                textBoxOut.Text = "Najpierw przekonwertuj dane.";
                return;
            }

            QuickSortMethod(intArray, 0, intArray.Length - 1);

            textBoxOut.Text = "Posortowana tablica: " + string.Join(", ", intArray.Take(15));
        }

        private void countingSort_Click(object sender, EventArgs e)
        {
            if (intArray == null || intArray.Length == 0)
            {
                textBoxOut.Text = "Najpierw przekonwertuj dane.";
                return;
            }

            int[] posortowane = CountingSortMethod(intArray);

            textBoxOut.Text = "Posortowana tablica: " + string.Join(", ", posortowane.Take(15));
        }

        private void textBoxOut_TextChanged(object sender, EventArgs e)
        {

        }


        // SORTOWANIA

        // BUBBLE SORT
        private void BubbleSortMethod(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }


        // INSERT SORT

        private void InsertSortMethod(int[] array)
        {
            int n = array.Length;
            int temp;

            for (int i = 1; i < n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }

        // MERGE SORT

        private int[] MergeSortMethod(int[] array)
        {
            if (array.Length <= 1)
                return array;

            int mid = array.Length / 2;
            int[] left = MergeSortMethod(array.Take(mid).ToArray());
            int[] right = MergeSortMethod(array.Skip(mid).ToArray());

            return Merge(left, right);
        }
        private int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int leftIndex = 0, rightIndex = 0, resultIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    result[resultIndex++] = left[leftIndex++];
                }
                else
                {
                    result[resultIndex++] = right[rightIndex++];
                }
            }

            while (leftIndex < left.Length)
            {
                result[resultIndex++] = left[leftIndex++];
            }
            while (rightIndex < right.Length)
            {
                result[resultIndex++] = right[rightIndex++];
            }

            return result;
        }



        // QUICK SORT

        private void QuickSortMethod(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);

                QuickSortMethod(array, low, pivotIndex - 1);
                QuickSortMethod(array, pivotIndex + 1, high);
            }
        }
        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }


        // COUNTING SORT

        private int[] CountingSortMethod(int[] array)
        {
            
            int max = array.Max();
            int min = array.Min();
            int range = max - min + 1;

            int[] count = new int[range];

            foreach (var num in array)
            {
                count[num - min]++;
            }

            int[] sortedArray = new int[array.Length];
            int index = 0;

            for (int i = 0; i < range; i++)
            {
                while (count[i] > 0)
                {
                    sortedArray[index++] = i + min;
                    count[i]--;
                }
            }

            return sortedArray;
        }
    }
}
