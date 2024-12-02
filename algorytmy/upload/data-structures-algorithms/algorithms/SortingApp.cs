using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    class SortingApp
    {
        private int[] _data;

        public int[] Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public SortingApp()
        {
            this.Data = Array.Empty<int>();
        }

        public string DisplayData()
        {
            if (Data.Length > 15)
            {
                int[] toDisplay = new int[15];
                Array.Copy(this.Data, toDisplay, toDisplay.Length);
                return NumArrayToString(toDisplay);
            }
            return NumArrayToString(this.Data);
        }

        public string DisplayData(int[] array)
        {
            if (array.Length > 15)
            {
                int[] toDisplay = new int[15];
                Array.Copy(array, toDisplay, toDisplay.Length);
                return NumArrayToString(toDisplay);
            }
            return NumArrayToString(array);
        }

        private static string NumArrayToString(int[] array)
        {
            return string.Join("; ", array);
        }
    }
}
