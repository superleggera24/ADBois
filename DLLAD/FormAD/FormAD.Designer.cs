namespace DLLAD
{
    partial class FormAD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SeqSearch = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BinarySearch = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SmartButton = new System.Windows.Forms.Button();
            this.BubbleButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CreateQueue = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CreateStack = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.CreateListButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(382, 371);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SeqSearch);
            this.tabPage1.Controls.Add(this.Max);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.BinarySearch);
            this.tabPage1.Controls.Add(this.SearchBox);
            this.tabPage1.Controls.Add(this.InsertButton);
            this.tabPage1.Controls.Add(this.SmartButton);
            this.tabPage1.Controls.Add(this.BubbleButton);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(374, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ArrayList";
            // 
            // SeqSearch
            // 
            this.SeqSearch.Location = new System.Drawing.Point(251, 91);
            this.SeqSearch.Name = "SeqSearch";
            this.SeqSearch.Size = new System.Drawing.Size(113, 50);
            this.SeqSearch.TabIndex = 8;
            this.SeqSearch.Text = "Sequential Search";
            this.SeqSearch.UseVisualStyleBackColor = true;
            this.SeqSearch.Click += new System.EventHandler(this.SeqSearch_Click);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(307, 183);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(57, 50);
            this.Max.TabIndex = 7;
            this.Max.Text = "Max";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Min";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BinarySearch
            // 
            this.BinarySearch.Location = new System.Drawing.Point(251, 35);
            this.BinarySearch.Name = "BinarySearch";
            this.BinarySearch.Size = new System.Drawing.Size(113, 50);
            this.BinarySearch.TabIndex = 5;
            this.BinarySearch.Text = "BinarySearch";
            this.BinarySearch.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(251, 7);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 22);
            this.SearchBox.TabIndex = 4;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(6, 183);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(95, 50);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Insertion Sort";
            this.InsertButton.UseVisualStyleBackColor = true;
            // 
            // SmartButton
            // 
            this.SmartButton.Location = new System.Drawing.Point(6, 127);
            this.SmartButton.Name = "SmartButton";
            this.SmartButton.Size = new System.Drawing.Size(95, 50);
            this.SmartButton.TabIndex = 2;
            this.SmartButton.Text = "Smart BubbleSort";
            this.SmartButton.UseVisualStyleBackColor = true;
            // 
            // BubbleButton
            // 
            this.BubbleButton.Location = new System.Drawing.Point(6, 71);
            this.BubbleButton.Name = "BubbleButton";
            this.BubbleButton.Size = new System.Drawing.Size(95, 50);
            this.BubbleButton.TabIndex = 1;
            this.BubbleButton.Text = "BubbleSort";
            this.BubbleButton.UseVisualStyleBackColor = true;
            this.BubbleButton.Click += new System.EventHandler(this.BubbleButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CreateQueue);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(374, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Queue";
            // 
            // CreateQueue
            // 
            this.CreateQueue.Location = new System.Drawing.Point(6, 6);
            this.CreateQueue.Name = "CreateQueue";
            this.CreateQueue.Size = new System.Drawing.Size(95, 50);
            this.CreateQueue.TabIndex = 1;
            this.CreateQueue.Text = "Create";
            this.CreateQueue.UseVisualStyleBackColor = true;
            this.CreateQueue.Click += new System.EventHandler(this.CreateQueue_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CreateStack);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(374, 342);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stack";
            // 
            // CreateStack
            // 
            this.CreateStack.Location = new System.Drawing.Point(4, 4);
            this.CreateStack.Name = "CreateStack";
            this.CreateStack.Size = new System.Drawing.Size(94, 51);
            this.CreateStack.TabIndex = 0;
            this.CreateStack.Text = "Create";
            this.CreateStack.UseVisualStyleBackColor = true;
            this.CreateStack.Click += new System.EventHandler(this.CreateStack_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(374, 342);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "PriorityQueue";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(374, 342);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "LinkedList";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(374, 342);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "DoublyLinkedList";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(374, 342);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "CircularList";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(374, 342);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "BinarySearchTree";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(567, 13);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultBox.Size = new System.Drawing.Size(320, 366);
            this.ResultBox.TabIndex = 1;
            // 
            // CreateListButton
            // 
            this.CreateListButton.Location = new System.Drawing.Point(431, 329);
            this.CreateListButton.Name = "CreateListButton";
            this.CreateListButton.Size = new System.Drawing.Size(95, 50);
            this.CreateListButton.TabIndex = 9;
            this.CreateListButton.Text = "ListCreation";
            this.CreateListButton.UseVisualStyleBackColor = true;
            this.CreateListButton.Click += new System.EventHandler(this.CreateList_Click);
            // 
            // FormAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 395);
            this.Controls.Add(this.CreateListButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAD";
            this.Text = "FormAD";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BinarySearch;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button SmartButton;
        private System.Windows.Forms.Button BubbleButton;
        private System.Windows.Forms.Button SeqSearch;
        private System.Windows.Forms.Button CreateListButton;
        private System.Windows.Forms.Button CreateQueue;
        private System.Windows.Forms.Button CreateStack;
    }
}