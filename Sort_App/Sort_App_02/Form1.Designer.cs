namespace Sort_App_02
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
            textBoxInput = new TextBox();
            convertButton = new Button();
            textBoxOut = new TextBox();
            bubbleSort = new Button();
            insertSort = new Button();
            mergeSort = new Button();
            quickSort = new Button();
            countingSort = new Button();
            numericUpDown = new NumericUpDown();
            generateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(102, 92);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(150, 27);
            textBoxInput.TabIndex = 0;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(102, 164);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(150, 29);
            convertButton.TabIndex = 1;
            convertButton.Text = "Konwertuj";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(102, 245);
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(581, 27);
            textBoxOut.TabIndex = 2;
            textBoxOut.TextChanged += textBoxOut_TextChanged;
            // 
            // bubbleSort
            // 
            bubbleSort.Location = new Point(102, 313);
            bubbleSort.Name = "bubbleSort";
            bubbleSort.Size = new Size(112, 29);
            bubbleSort.TabIndex = 3;
            bubbleSort.Text = "Bubble_Sort";
            bubbleSort.UseVisualStyleBackColor = true;
            bubbleSort.Click += bubbleSort_Click;
            // 
            // insertSort
            // 
            insertSort.Location = new Point(243, 313);
            insertSort.Name = "insertSort";
            insertSort.Size = new Size(94, 29);
            insertSort.TabIndex = 4;
            insertSort.Text = "Insert_Sort";
            insertSort.UseVisualStyleBackColor = true;
            insertSort.Click += insertSort_Click;
            // 
            // mergeSort
            // 
            mergeSort.Location = new Point(360, 313);
            mergeSort.Name = "mergeSort";
            mergeSort.Size = new Size(94, 29);
            mergeSort.TabIndex = 5;
            mergeSort.Text = "Merge_Sort";
            mergeSort.UseVisualStyleBackColor = true;
            mergeSort.Click += mergeSort_Click;
            // 
            // quickSort
            // 
            quickSort.Location = new Point(471, 313);
            quickSort.Name = "quickSort";
            quickSort.Size = new Size(94, 29);
            quickSort.TabIndex = 6;
            quickSort.Text = "Quick_Sort";
            quickSort.UseVisualStyleBackColor = true;
            quickSort.Click += quickSort_Click;
            // 
            // countingSort
            // 
            countingSort.Location = new Point(589, 313);
            countingSort.Name = "countingSort";
            countingSort.Size = new Size(94, 29);
            countingSort.TabIndex = 7;
            countingSort.Text = "Counting_Sort";
            countingSort.UseVisualStyleBackColor = true;
            countingSort.Click += countingSort_Click;
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(471, 92);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(150, 27);
            numericUpDown.TabIndex = 8;
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(476, 159);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(94, 29);
            generateButton.TabIndex = 9;
            generateButton.Text = "Generuj";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(generateButton);
            Controls.Add(numericUpDown);
            Controls.Add(countingSort);
            Controls.Add(quickSort);
            Controls.Add(mergeSort);
            Controls.Add(insertSort);
            Controls.Add(bubbleSort);
            Controls.Add(textBoxOut);
            Controls.Add(convertButton);
            Controls.Add(textBoxInput);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button convertButton;
        private TextBox textBoxOut;
        private Button bubbleSort;
        private Button insertSort;
        private Button mergeSort;
        private Button quickSort;
        private Button countingSort;
        private NumericUpDown numericUpDown;
        private Button generateButton;
    }
}
