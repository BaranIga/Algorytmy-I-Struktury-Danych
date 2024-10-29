using System.Windows.Forms.VisualStyles;

namespace TreeView_Program
{
    public partial class Form1 : Form
    {
        private BTS tree;
        public Form1()
        {
            InitializeComponent();
            tree = new BTS();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInput.Text, out int value))
            {
                tree.Add(value);
                textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("WprowadŸ liczbê!");
            }
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void showTree_Click(object sender, EventArgs e)
        {
            TreeView.Nodes.Clear();
            TreeNode rootNode = new TreeNode("Root");

            tree.FillTreeView(tree.root, rootNode);

            if(rootNode.Nodes.Count > 0)
            {
                TreeView.Nodes.Add(rootNode);
                TreeView.ExpandAll();
            }
        }
    }
}
