using dsa.algorithms.sort;
using dsa.utils;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace algorithms
{
    public partial class MainForm : Form
    {

        private readonly SortingApp _sortingApp;
        private dsa.structures.list.LinkedList<int> _linkedList;

        public MainForm()
        {
            InitializeComponent();
            _sortingApp = new SortingApp();
            _linkedList = new dsa.structures.list.LinkedList<int>();
        }

        private void SubmitDataBtn_Click(object sender, EventArgs e)
        {
            int[] ints;
            try
            {
                _sortingApp.Data = this.InputToNumArray(this.dataInput.Text, @"\s+");
                this.inputDisplay.Text = _sortingApp.DisplayData();
                this.inputDisplay.ForeColor = Color.Black;
            }
            catch (InvalidDataException ex)
            {
                this.inputDisplay.Text = "INVALID INPUT";
                this.inputDisplay.ForeColor = Color.Red;
                return;
            }
        }

        private void generatorBtn_Click(object sender, EventArgs e)
        {
            int len = Convert.ToInt32(this.generatorLengthPicker.Value);
            Generator generator = new Generator();
            int[] randArr = generator.RandArray(len, 0, 1000);
            _sortingApp.Data = randArr;
            this.inputDisplay.Text = _sortingApp.DisplayData();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            AlgComboItem selectedAlgItem = (AlgComboItem)this.algorithmComboBox.SelectedItem;
            this.statusInfo.Text = $"Sorting with {selectedAlgItem.Text} in progress...";
            this.statusInfo.Refresh();
            ISortingAlgorithm alg = IdToAlgorithm(selectedAlgItem.Id);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] sortedCopy = new int[_sortingApp.Data.Length];
            Array.Copy(_sortingApp.Data, sortedCopy, sortedCopy.Length);
            alg.Sort(sortedCopy);
            stopwatch.Stop();
            this.outputDisplay.Text = _sortingApp.DisplayData(sortedCopy);
            this.runningTime.Text = $"{stopwatch.ElapsedMilliseconds} ms | {stopwatch.ElapsedTicks} ticks";
            this.statusInfo.Text = "Sorting completed!";
        }

        private int[] InputToNumArray(string input, string sepPattern)
        {
            input = input.Trim();
            string[] dataArray = Regex.Split(input, sepPattern);
            int[] numDataArray = new int[dataArray.Length];
            for (int i = 0; i < dataArray.Length; i++)
            {
                try
                {
                    numDataArray[i] = int.Parse(dataArray[i]);
                }
                catch (Exception ex)
                {
                    throw new InvalidDataException();
                }
            }
            return numDataArray;
        }

        private string NumArrayToString(int[] array)
        {
            return string.Join("; ", array);
        }

        private static ISortingAlgorithm IdToAlgorithm(int id)
        {
            Dictionary<int, ISortingAlgorithm> algDict = new Dictionary<int, ISortingAlgorithm>();
            algDict.Add(1, new BubbleSort());
            algDict.Add(2, new InsertionSort());
            algDict.Add(3, new SelectionSort());
            algDict.Add(4, new MergeSort());
            algDict.Add(5, new QuickSort());
            return algDict[id];
        }

        private void displayLinkedListInfo()
        {
            this.linkedListContents.Text = _linkedList.ToString();
            this.linkedListLength.Text = _linkedList.Count.ToString();
        }

        private void addFirstLLBtn_Click(object sender, EventArgs e)
        {
            _linkedList.AddFirst((int)this.linkedListNewValue.Value);
            displayLinkedListInfo();
        }

        private void addLastLLBtn_Click(object sender, EventArgs e)
        {
            _linkedList.AddLast((int)this.linkedListNewValue.Value);
            displayLinkedListInfo();
        }

        private void removeFirstLLBtn_Click(object sender, EventArgs e)
        {
            _linkedList.RemoveFirst();
            displayLinkedListInfo();
        }

        private void removeLastLLBtn_Click(object sender, EventArgs e)
        {
            _linkedList.RemoveLast();
            displayLinkedListInfo();
        }
    }
}
