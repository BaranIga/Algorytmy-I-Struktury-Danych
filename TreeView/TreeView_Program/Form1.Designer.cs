namespace TreeView_Program
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeView = new TreeView();
            textBoxInput = new TextBox();
            Add = new Button();
            showTree = new Button();
            SuspendLayout();
            // 
            // TreeView
            // 
            TreeView.Location = new Point(219, 206);
            TreeView.Name = "TreeView";
            TreeView.Size = new Size(390, 195);
            TreeView.TabIndex = 0;
            TreeView.AfterSelect += TreeView_AfterSelect;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(146, 80);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(125, 27);
            textBoxInput.TabIndex = 1;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // Add
            // 
            Add.Location = new Point(439, 87);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 2;
            Add.Text = "button1";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // showTree
            // 
            showTree.Location = new Point(277, 135);
            showTree.Name = "showTree";
            showTree.Size = new Size(94, 29);
            showTree.TabIndex = 3;
            showTree.Text = "Show_Tree";
            showTree.UseVisualStyleBackColor = true;
            showTree.Click += showTree_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showTree);
            Controls.Add(Add);
            Controls.Add(textBoxInput);
            Controls.Add(TreeView);
            Name = "Form1";
            Text = "Dodaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView TreeView;
        private TextBox textBoxInput;
        private Button Add;
        private Button showTree;
    }
}
