using dsa;

namespace algorithms
{
    partial class MainForm
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
            AlgComboItem algComboItem6 = new AlgComboItem();
            AlgComboItem algComboItem7 = new AlgComboItem();
            AlgComboItem algComboItem8 = new AlgComboItem();
            AlgComboItem algComboItem9 = new AlgComboItem();
            AlgComboItem algComboItem10 = new AlgComboItem();
            dataInput = new TextBox();
            dataInputLabel = new Label();
            submitDataBtn = new Button();
            inputDisplayLabel = new Label();
            inputDisplay = new Label();
            outputDisplayLabel = new Label();
            outputDisplay = new Label();
            splitContainer1 = new SplitContainer();
            generatorBtn = new Button();
            generatorLabel = new Label();
            generatorLengthPicker = new NumericUpDown();
            applyBtn = new Button();
            timeLabel = new Label();
            runningTime = new Label();
            algorithmComboBox = new ComboBox();
            statusLabel = new Label();
            statusInfo = new Label();
            globalTabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            structuresTabControl = new TabControl();
            linkedListTabPage = new TabPage();
            linkedListNewValue = new NumericUpDown();
            linkedListNewValueLabel = new Label();
            linkedListLength = new Label();
            linkedListLengthLabel = new Label();
            linkedListActionsPanel = new Panel();
            removeLastLLBtn = new Button();
            addFirstLLBtn = new Button();
            removeFirstLLBtn = new Button();
            addLastLLBtn = new Button();
            linkedListContents = new Label();
            linkedListContentsLabel = new Label();
            bstTabPage = new TabPage();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)generatorLengthPicker).BeginInit();
            globalTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            structuresTabControl.SuspendLayout();
            linkedListTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)linkedListNewValue).BeginInit();
            linkedListActionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataInput
            // 
            dataInput.Anchor = AnchorStyles.Top;
            dataInput.Location = new Point(36, 51);
            dataInput.Margin = new Padding(4);
            dataInput.Name = "dataInput";
            dataInput.Size = new Size(425, 34);
            dataInput.TabIndex = 0;
            // 
            // dataInputLabel
            // 
            dataInputLabel.Anchor = AnchorStyles.Top;
            dataInputLabel.AutoSize = true;
            dataInputLabel.Location = new Point(178, 11);
            dataInputLabel.Margin = new Padding(4, 0, 4, 8);
            dataInputLabel.Name = "dataInputLabel";
            dataInputLabel.Size = new Size(142, 28);
            dataInputLabel.TabIndex = 1;
            dataInputLabel.Text = "Enter numbers:";
            // 
            // submitDataBtn
            // 
            submitDataBtn.Anchor = AnchorStyles.Top;
            submitDataBtn.Location = new Point(191, 124);
            submitDataBtn.Margin = new Padding(3, 10, 3, 3);
            submitDataBtn.Name = "submitDataBtn";
            submitDataBtn.Size = new Size(129, 41);
            submitDataBtn.TabIndex = 2;
            submitDataBtn.Text = "Submit data";
            submitDataBtn.UseVisualStyleBackColor = true;
            submitDataBtn.Click += SubmitDataBtn_Click;
            // 
            // inputDisplayLabel
            // 
            inputDisplayLabel.AutoSize = true;
            inputDisplayLabel.Location = new Point(20, 253);
            inputDisplayLabel.Margin = new Padding(10, 0, 3, 0);
            inputDisplayLabel.Name = "inputDisplayLabel";
            inputDisplayLabel.Size = new Size(172, 28);
            inputDisplayLabel.TabIndex = 3;
            inputDisplayLabel.Text = "Input (the first 15):";
            // 
            // inputDisplay
            // 
            inputDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputDisplay.BackColor = Color.Gainsboro;
            inputDisplay.Location = new Point(13, 288);
            inputDisplay.Name = "inputDisplay";
            inputDisplay.Size = new Size(770, 32);
            inputDisplay.TabIndex = 4;
            inputDisplay.Text = "...";
            inputDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // outputDisplayLabel
            // 
            outputDisplayLabel.AutoSize = true;
            outputDisplayLabel.Location = new Point(20, 389);
            outputDisplayLabel.Name = "outputDisplayLabel";
            outputDisplayLabel.Size = new Size(189, 28);
            outputDisplayLabel.TabIndex = 5;
            outputDisplayLabel.Text = "Output (the first 15):";
            // 
            // outputDisplay
            // 
            outputDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            outputDisplay.BackColor = Color.Gainsboro;
            outputDisplay.Location = new Point(13, 423);
            outputDisplay.Name = "outputDisplay";
            outputDisplay.Size = new Size(770, 32);
            outputDisplay.TabIndex = 6;
            outputDisplay.Text = "...";
            outputDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(23, 27);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataInputLabel);
            splitContainer1.Panel1.Controls.Add(submitDataBtn);
            splitContainer1.Panel1.Controls.Add(dataInput);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(generatorBtn);
            splitContainer1.Panel2.Controls.Add(generatorLabel);
            splitContainer1.Panel2.Controls.Add(generatorLengthPicker);
            splitContainer1.Size = new Size(760, 201);
            splitContainer1.SplitterDistance = 497;
            splitContainer1.TabIndex = 7;
            // 
            // generatorBtn
            // 
            generatorBtn.Location = new Point(74, 124);
            generatorBtn.Name = "generatorBtn";
            generatorBtn.Size = new Size(109, 41);
            generatorBtn.TabIndex = 2;
            generatorBtn.Text = "Generate";
            generatorBtn.UseVisualStyleBackColor = true;
            generatorBtn.Click += generatorBtn_Click;
            // 
            // generatorLabel
            // 
            generatorLabel.AutoSize = true;
            generatorLabel.Location = new Point(47, 11);
            generatorLabel.Name = "generatorLabel";
            generatorLabel.Size = new Size(165, 28);
            generatorLabel.TabIndex = 1;
            generatorLabel.Text = "Generate random";
            // 
            // generatorLengthPicker
            // 
            generatorLengthPicker.Location = new Point(47, 52);
            generatorLengthPicker.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            generatorLengthPicker.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            generatorLengthPicker.Name = "generatorLengthPicker";
            generatorLengthPicker.Size = new Size(150, 34);
            generatorLengthPicker.TabIndex = 0;
            generatorLengthPicker.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // applyBtn
            // 
            applyBtn.Location = new Point(351, 345);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(94, 42);
            applyBtn.TabIndex = 8;
            applyBtn.Text = "Apply";
            applyBtn.UseVisualStyleBackColor = true;
            applyBtn.Click += applyBtn_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(415, 493);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(133, 28);
            timeLabel.TabIndex = 9;
            timeLabel.Text = "Running time:";
            // 
            // runningTime
            // 
            runningTime.AutoSize = true;
            runningTime.Location = new Point(415, 523);
            runningTime.MinimumSize = new Size(100, 0);
            runningTime.Name = "runningTime";
            runningTime.Size = new Size(100, 28);
            runningTime.TabIndex = 10;
            runningTime.Text = "...";
            // 
            // algorithmComboBox
            // 
            algorithmComboBox.DisplayMember = "Text";
            algorithmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            algorithmComboBox.FormattingEnabled = true;
            algComboItem6.Id = 1;
            algComboItem6.Text = "Bubble sort";
            algComboItem7.Id = 2;
            algComboItem7.Text = "Insertion sort";
            algComboItem8.Id = 3;
            algComboItem8.Text = "Selection sort";
            algComboItem9.Id = 4;
            algComboItem9.Text = "Mergesort";
            algComboItem10.Id = 5;
            algComboItem10.Text = "Quicksort";
            algorithmComboBox.Items.AddRange(new object[] { algComboItem6, algComboItem7, algComboItem8, algComboItem9, algComboItem10 });
            algorithmComboBox.Location = new Point(78, 345);
            algorithmComboBox.Name = "algorithmComboBox";
            algorithmComboBox.Size = new Size(151, 36);
            algorithmComboBox.TabIndex = 11;
            algorithmComboBox.ValueMember = "Id";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(50, 493);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(69, 28);
            statusLabel.TabIndex = 12;
            statusLabel.Text = "Status:";
            // 
            // statusInfo
            // 
            statusInfo.AutoSize = true;
            statusInfo.Location = new Point(50, 523);
            statusInfo.MinimumSize = new Size(100, 0);
            statusInfo.Name = "statusInfo";
            statusInfo.Size = new Size(100, 28);
            statusInfo.TabIndex = 13;
            statusInfo.Text = "...";
            // 
            // globalTabControl
            // 
            globalTabControl.Controls.Add(tabPage1);
            globalTabControl.Controls.Add(tabPage2);
            globalTabControl.Location = new Point(12, 12);
            globalTabControl.Name = "globalTabControl";
            globalTabControl.SelectedIndex = 0;
            globalTabControl.Size = new Size(805, 696);
            globalTabControl.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(outputDisplay);
            tabPage1.Controls.Add(statusInfo);
            tabPage1.Controls.Add(inputDisplayLabel);
            tabPage1.Controls.Add(statusLabel);
            tabPage1.Controls.Add(inputDisplay);
            tabPage1.Controls.Add(algorithmComboBox);
            tabPage1.Controls.Add(outputDisplayLabel);
            tabPage1.Controls.Add(runningTime);
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Controls.Add(timeLabel);
            tabPage1.Controls.Add(applyBtn);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(797, 655);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Algorithms";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(structuresTabControl);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(797, 655);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Structures";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // structuresTabControl
            // 
            structuresTabControl.Controls.Add(linkedListTabPage);
            structuresTabControl.Controls.Add(bstTabPage);
            structuresTabControl.Location = new Point(6, 6);
            structuresTabControl.Name = "structuresTabControl";
            structuresTabControl.SelectedIndex = 0;
            structuresTabControl.Size = new Size(785, 643);
            structuresTabControl.TabIndex = 0;
            // 
            // linkedListTabPage
            // 
            linkedListTabPage.Controls.Add(linkedListLength);
            linkedListTabPage.Controls.Add(linkedListLengthLabel);
            linkedListTabPage.Controls.Add(linkedListActionsPanel);
            linkedListTabPage.Controls.Add(linkedListContents);
            linkedListTabPage.Controls.Add(linkedListContentsLabel);
            linkedListTabPage.Location = new Point(4, 37);
            linkedListTabPage.Name = "linkedListTabPage";
            linkedListTabPage.Padding = new Padding(3);
            linkedListTabPage.Size = new Size(777, 602);
            linkedListTabPage.TabIndex = 0;
            linkedListTabPage.Text = "Linked List";
            linkedListTabPage.UseVisualStyleBackColor = true;
            // 
            // linkedListNewValue
            // 
            linkedListNewValue.Location = new Point(22, 62);
            linkedListNewValue.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            linkedListNewValue.Name = "linkedListNewValue";
            linkedListNewValue.Size = new Size(150, 34);
            linkedListNewValue.TabIndex = 10;
            // 
            // linkedListNewValueLabel
            // 
            linkedListNewValueLabel.AutoSize = true;
            linkedListNewValueLabel.Location = new Point(22, 22);
            linkedListNewValueLabel.Name = "linkedListNewValueLabel";
            linkedListNewValueLabel.Size = new Size(147, 28);
            linkedListNewValueLabel.TabIndex = 9;
            linkedListNewValueLabel.Text = "Choose a value:";
            // 
            // linkedListLength
            // 
            linkedListLength.AutoSize = true;
            linkedListLength.Location = new Point(43, 183);
            linkedListLength.Name = "linkedListLength";
            linkedListLength.Size = new Size(24, 28);
            linkedListLength.TabIndex = 8;
            linkedListLength.Text = "...";
            // 
            // linkedListLengthLabel
            // 
            linkedListLengthLabel.AutoSize = true;
            linkedListLengthLabel.Location = new Point(31, 133);
            linkedListLengthLabel.Name = "linkedListLengthLabel";
            linkedListLengthLabel.Size = new Size(76, 28);
            linkedListLengthLabel.TabIndex = 7;
            linkedListLengthLabel.Text = "Length:";
            // 
            // linkedListActionsPanel
            // 
            linkedListActionsPanel.Controls.Add(linkedListNewValue);
            linkedListActionsPanel.Controls.Add(linkedListNewValueLabel);
            linkedListActionsPanel.Controls.Add(removeLastLLBtn);
            linkedListActionsPanel.Controls.Add(addFirstLLBtn);
            linkedListActionsPanel.Controls.Add(removeFirstLLBtn);
            linkedListActionsPanel.Controls.Add(addLastLLBtn);
            linkedListActionsPanel.Location = new Point(31, 394);
            linkedListActionsPanel.Name = "linkedListActionsPanel";
            linkedListActionsPanel.Size = new Size(705, 184);
            linkedListActionsPanel.TabIndex = 6;
            // 
            // removeLastLLBtn
            // 
            removeLastLLBtn.Location = new Point(543, 127);
            removeLastLLBtn.Name = "removeLastLLBtn";
            removeLastLLBtn.Size = new Size(132, 39);
            removeLastLLBtn.TabIndex = 5;
            removeLastLLBtn.Text = "Remove last";
            removeLastLLBtn.UseVisualStyleBackColor = true;
            removeLastLLBtn.Click += removeLastLLBtn_Click;
            // 
            // addFirstLLBtn
            // 
            addFirstLLBtn.Location = new Point(22, 127);
            addFirstLLBtn.Name = "addFirstLLBtn";
            addFirstLLBtn.Size = new Size(128, 38);
            addFirstLLBtn.TabIndex = 2;
            addFirstLLBtn.Text = "Add first";
            addFirstLLBtn.UseVisualStyleBackColor = true;
            addFirstLLBtn.Click += addFirstLLBtn_Click;
            // 
            // removeFirstLLBtn
            // 
            removeFirstLLBtn.Location = new Point(354, 127);
            removeFirstLLBtn.Name = "removeFirstLLBtn";
            removeFirstLLBtn.Size = new Size(133, 39);
            removeFirstLLBtn.TabIndex = 4;
            removeFirstLLBtn.Text = "Remove first";
            removeFirstLLBtn.UseVisualStyleBackColor = true;
            removeFirstLLBtn.Click += removeFirstLLBtn_Click;
            // 
            // addLastLLBtn
            // 
            addLastLLBtn.Location = new Point(187, 127);
            addLastLLBtn.Name = "addLastLLBtn";
            addLastLLBtn.Size = new Size(122, 39);
            addLastLLBtn.TabIndex = 3;
            addLastLLBtn.Text = "Add last";
            addLastLLBtn.UseVisualStyleBackColor = true;
            addLastLLBtn.Click += addLastLLBtn_Click;
            // 
            // linkedListContents
            // 
            linkedListContents.AutoSize = true;
            linkedListContents.Location = new Point(43, 78);
            linkedListContents.Name = "linkedListContents";
            linkedListContents.Size = new Size(24, 28);
            linkedListContents.TabIndex = 1;
            linkedListContents.Text = "...";
            // 
            // linkedListContentsLabel
            // 
            linkedListContentsLabel.AutoSize = true;
            linkedListContentsLabel.Location = new Point(31, 34);
            linkedListContentsLabel.Name = "linkedListContentsLabel";
            linkedListContentsLabel.Size = new Size(94, 28);
            linkedListContentsLabel.TabIndex = 0;
            linkedListContentsLabel.Text = "Contents:";
            // 
            // bstTabPage
            // 
            bstTabPage.Location = new Point(4, 37);
            bstTabPage.Name = "bstTabPage";
            bstTabPage.Padding = new Padding(3);
            bstTabPage.Size = new Size(777, 602);
            bstTabPage.TabIndex = 1;
            bstTabPage.Text = "BST";
            bstTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 718);
            Controls.Add(globalTabControl);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimumSize = new Size(847, 765);
            Name = "MainForm";
            Text = "Algorithms";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)generatorLengthPicker).EndInit();
            globalTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            structuresTabControl.ResumeLayout(false);
            linkedListTabPage.ResumeLayout(false);
            linkedListTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)linkedListNewValue).EndInit();
            linkedListActionsPanel.ResumeLayout(false);
            linkedListActionsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox dataInput;
        private Label dataInputLabel;
        private Button submitDataBtn;
        private Label inputDisplayLabel;
        private Label inputDisplay;
        private Label outputDisplayLabel;
        private Label outputDisplay;
        private SplitContainer splitContainer1;
        private Label generatorLabel;
        private NumericUpDown generatorLengthPicker;
        private Button generatorBtn;
        private Button applyBtn;
        private Label timeLabel;
        private Label runningTime;
        private ComboBox algorithmComboBox;
        private Label statusLabel;
        private Label statusInfo;
        private TabControl globalTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl structuresTabControl;
        private TabPage linkedListTabPage;
        private TabPage bstTabPage;
        private Label linkedListContentsLabel;
        private Panel linkedListActionsPanel;
        private Button removeLastLLBtn;
        private Button addFirstLLBtn;
        private Button removeFirstLLBtn;
        private Button addLastLLBtn;
        private Label linkedListContents;
        private Label linkedListLength;
        private Label linkedListLengthLabel;
        private NumericUpDown linkedListNewValue;
        private Label linkedListNewValueLabel;
    }
}
