using System.Collections;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace praca_domowa_02
{
    public partial class Form1 : Form
    {
        private List list;

        public Form1()
        {
            InitializeComponent();
            list = new List();
        }

        private void addFirst_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            int inputNumber;
            int.TryParse(input, out inputNumber);

            list.AddFirst(inputNumber);

            textBoxOut.Text = list.ToString();

            textBoxInput.Clear();
        }

        private void addLast_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            int inputNumber;
            int.TryParse(input, out inputNumber);

            list.AddLast(inputNumber);

            textBoxOut.Text = list.ToString();

            textBoxInput.Clear();
        }

        private void textBoxOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void removeFirst_Click(object sender, EventArgs e)
        {
            list.RemoveFirst();

            textBoxOut.Text = list.ToString();
        }

        private void removeLast_Click(object sender, EventArgs e)
        {
            list.RemoveLast();

            textBoxOut.Text = list.ToString();
        }

        private void get_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            int index;

            if (int.TryParse(input, out index))
            {
                try
                {
                    int element = list.Get(index);
                    textBoxOut.Text = element.ToString();
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Proszê podaæ poprawny numer indeksu.");
            }

            textBoxInput.Clear();
        }

        private void toString_Click(object sender, EventArgs e)
        {
            list.ToString();

            textBoxOut.Text = list.ToString();
        }
    }
}
