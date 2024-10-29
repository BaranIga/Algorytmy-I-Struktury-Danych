namespace praca_domowa_02
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
            addFirst = new Button();
            textBoxOut = new TextBox();
            textBoxInput = new TextBox();
            addLast = new Button();
            removeFirst = new Button();
            removeLast = new Button();
            get = new Button();
            toString = new Button();
            SuspendLayout();
            // 
            // addFirst
            // 
            addFirst.Location = new Point(72, 90);
            addFirst.Name = "addFirst";
            addFirst.Size = new Size(117, 52);
            addFirst.TabIndex = 0;
            addFirst.Text = "Add_First";
            addFirst.UseVisualStyleBackColor = true;
            addFirst.Click += addFirst_Click;
            // 
            // textBoxOut
            // 
            textBoxOut.BorderStyle = BorderStyle.FixedSingle;
            textBoxOut.Location = new Point(72, 292);
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(660, 27);
            textBoxOut.TabIndex = 1;
            textBoxOut.TextChanged += textBoxOut_TextChanged;
            // 
            // textBoxInput
            // 
            textBoxInput.BorderStyle = BorderStyle.FixedSingle;
            textBoxInput.Location = new Point(301, 42);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(179, 27);
            textBoxInput.TabIndex = 2;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // addLast
            // 
            addLast.Location = new Point(195, 90);
            addLast.Name = "addLast";
            addLast.Size = new Size(117, 52);
            addLast.TabIndex = 3;
            addLast.Text = "Add_Last";
            addLast.UseVisualStyleBackColor = true;
            addLast.Click += addLast_Click;
            // 
            // removeFirst
            // 
            removeFirst.Location = new Point(615, 90);
            removeFirst.Name = "removeFirst";
            removeFirst.Size = new Size(117, 52);
            removeFirst.TabIndex = 4;
            removeFirst.Text = "Remove_First";
            removeFirst.UseVisualStyleBackColor = true;
            removeFirst.Click += removeFirst_Click;
            // 
            // removeLast
            // 
            removeLast.Location = new Point(492, 90);
            removeLast.Name = "removeLast";
            removeLast.Size = new Size(117, 52);
            removeLast.TabIndex = 5;
            removeLast.Text = "Remove_Last";
            removeLast.UseVisualStyleBackColor = true;
            removeLast.Click += removeLast_Click;
            // 
            // get
            // 
            get.Location = new Point(344, 90);
            get.Name = "get";
            get.Size = new Size(117, 52);
            get.TabIndex = 6;
            get.Text = "Get";
            get.UseVisualStyleBackColor = true;
            get.Click += get_Click;
            // 
            // toString
            // 
            toString.Location = new Point(344, 148);
            toString.Name = "toString";
            toString.Size = new Size(117, 52);
            toString.TabIndex = 7;
            toString.Text = "ToString";
            toString.UseVisualStyleBackColor = true;
            toString.Click += toString_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(toString);
            Controls.Add(get);
            Controls.Add(removeLast);
            Controls.Add(removeFirst);
            Controls.Add(addLast);
            Controls.Add(textBoxInput);
            Controls.Add(textBoxOut);
            Controls.Add(addFirst);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addFirst;
        private TextBox textBoxOut;
        private TextBox textBoxInput;
        private Button addLast;
        private Button removeFirst;
        private Button removeLast;
        private Button get;
        private Button toString;
    }
}
