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
            this.Show = new System.Windows.Forms.Button();
            this.SeqSearch = new System.Windows.Forms.Button();
            this.BinarySearch = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SmartButton = new System.Windows.Forms.Button();
            this.BubbleButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.ShowNext = new System.Windows.Forms.Button();
            this.IteratorShow = new System.Windows.Forms.TextBox();
            this.CreateStack = new System.Windows.Forms.Button();
            this.CreatePriorityQueue = new System.Windows.Forms.Button();
            this.CreateQueue = new System.Windows.Forms.Button();
            this.InsertAfter = new System.Windows.Forms.Button();
            this.InsertBefore = new System.Windows.Forms.Button();
            this.CreateCircularLinkedList = new System.Windows.Forms.Button();
            this.CreateDoubly = new System.Windows.Forms.Button();
            this.CreateLinkedList = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BinaryMax = new System.Windows.Forms.Button();
            this.BinaryMin = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.CreateQuadraticHash = new System.Windows.Forms.Button();
            this.CreateLinearHash = new System.Windows.Forms.Button();
            this.CreateBucketHash = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.AllButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 370);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Show);
            this.tabPage1.Controls.Add(this.SeqSearch);
            this.tabPage1.Controls.Add(this.BinarySearch);
            this.tabPage1.Controls.Add(this.Max);
            this.tabPage1.Controls.Add(this.SearchBox);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.InsertButton);
            this.tabPage1.Controls.Add(this.SmartButton);
            this.tabPage1.Controls.Add(this.BubbleButton);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(528, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ArrayList";
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(247, 258);
            this.Show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(117, 78);
            this.Show.TabIndex = 9;
            this.Show.Text = "Show Current Array";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // SeqSearch
            // 
            this.SeqSearch.Location = new System.Drawing.Point(251, 91);
            this.SeqSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeqSearch.Name = "SeqSearch";
            this.SeqSearch.Size = new System.Drawing.Size(113, 59);
            this.SeqSearch.TabIndex = 8;
            this.SeqSearch.Text = "Sequential Search";
            this.SeqSearch.UseVisualStyleBackColor = true;
            this.SeqSearch.Click += new System.EventHandler(this.SeqSearch_Click);
            // 
            // BinarySearch
            // 
            this.BinarySearch.Location = new System.Drawing.Point(251, 34);
            this.BinarySearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BinarySearch.Name = "BinarySearch";
            this.BinarySearch.Size = new System.Drawing.Size(113, 50);
            this.BinarySearch.TabIndex = 5;
            this.BinarySearch.Text = "BinarySearch";
            this.BinarySearch.UseVisualStyleBackColor = true;
            this.BinarySearch.Click += new System.EventHandler(this.BinarySearch_Click);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(307, 165);
            this.Max.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(59, 50);
            this.Max.TabIndex = 7;
            this.Max.Text = "Max";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(251, 7);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(113, 22);
            this.SearchBox.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 165);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Min";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(5, 206);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(121, 70);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Insertion Sort";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // SmartButton
            // 
            this.SmartButton.Location = new System.Drawing.Point(5, 138);
            this.SmartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SmartButton.Name = "SmartButton";
            this.SmartButton.Size = new System.Drawing.Size(121, 62);
            this.SmartButton.TabIndex = 2;
            this.SmartButton.Text = "Smart BubbleSort";
            this.SmartButton.UseVisualStyleBackColor = true;
            this.SmartButton.Click += new System.EventHandler(this.SmartButton_Click);
            // 
            // BubbleButton
            // 
            this.BubbleButton.Location = new System.Drawing.Point(5, 71);
            this.BubbleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BubbleButton.Name = "BubbleButton";
            this.BubbleButton.Size = new System.Drawing.Size(121, 62);
            this.BubbleButton.TabIndex = 1;
            this.BubbleButton.Text = "BubbleSort";
            this.BubbleButton.UseVisualStyleBackColor = true;
            this.BubbleButton.Click += new System.EventHandler(this.BubbleButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.ShowNext);
            this.tabPage5.Controls.Add(this.IteratorShow);
            this.tabPage5.Controls.Add(this.CreateStack);
            this.tabPage5.Controls.Add(this.CreatePriorityQueue);
            this.tabPage5.Controls.Add(this.CreateQueue);
            this.tabPage5.Controls.Add(this.InsertAfter);
            this.tabPage5.Controls.Add(this.InsertBefore);
            this.tabPage5.Controls.Add(this.CreateCircularLinkedList);
            this.tabPage5.Controls.Add(this.CreateDoubly);
            this.tabPage5.Controls.Add(this.CreateLinkedList);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(528, 341);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Other Collections";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 262);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Empty output";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ShowNext
            // 
            this.ShowNext.Location = new System.Drawing.Point(136, 171);
            this.ShowNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowNext.Name = "ShowNext";
            this.ShowNext.Size = new System.Drawing.Size(93, 85);
            this.ShowNext.TabIndex = 10;
            this.ShowNext.Text = "Show Next In Collection";
            this.ShowNext.UseVisualStyleBackColor = true;
            this.ShowNext.Click += new System.EventHandler(this.ShowNext_Click);
            // 
            // IteratorShow
            // 
            this.IteratorShow.Location = new System.Drawing.Point(235, 16);
            this.IteratorShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IteratorShow.Multiline = true;
            this.IteratorShow.Name = "IteratorShow";
            this.IteratorShow.ReadOnly = true;
            this.IteratorShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IteratorShow.Size = new System.Drawing.Size(167, 239);
            this.IteratorShow.TabIndex = 9;
            // 
            // CreateStack
            // 
            this.CreateStack.Location = new System.Drawing.Point(408, 174);
            this.CreateStack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateStack.Name = "CreateStack";
            this.CreateStack.Size = new System.Drawing.Size(112, 82);
            this.CreateStack.TabIndex = 8;
            this.CreateStack.Text = "Create Stack";
            this.CreateStack.UseVisualStyleBackColor = true;
            this.CreateStack.Click += new System.EventHandler(this.CreateStack_Click);
            // 
            // CreatePriorityQueue
            // 
            this.CreatePriorityQueue.Location = new System.Drawing.Point(407, 82);
            this.CreatePriorityQueue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreatePriorityQueue.Name = "CreatePriorityQueue";
            this.CreatePriorityQueue.Size = new System.Drawing.Size(112, 85);
            this.CreatePriorityQueue.TabIndex = 7;
            this.CreatePriorityQueue.Text = "Create PriorityQueue";
            this.CreatePriorityQueue.UseVisualStyleBackColor = true;
            this.CreatePriorityQueue.Click += new System.EventHandler(this.CreatePriorityQueue_Click_1);
            // 
            // CreateQueue
            // 
            this.CreateQueue.Location = new System.Drawing.Point(408, 14);
            this.CreateQueue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateQueue.Name = "CreateQueue";
            this.CreateQueue.Size = new System.Drawing.Size(112, 64);
            this.CreateQueue.TabIndex = 6;
            this.CreateQueue.Text = "Create Queue";
            this.CreateQueue.UseVisualStyleBackColor = true;
            this.CreateQueue.Click += new System.EventHandler(this.CreateQueue_Click_1);
            // 
            // InsertAfter
            // 
            this.InsertAfter.Location = new System.Drawing.Point(136, 82);
            this.InsertAfter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertAfter.Name = "InsertAfter";
            this.InsertAfter.Size = new System.Drawing.Size(93, 85);
            this.InsertAfter.TabIndex = 5;
            this.InsertAfter.Text = "Insert After";
            this.InsertAfter.UseVisualStyleBackColor = true;
            this.InsertAfter.Click += new System.EventHandler(this.InsertAfter_Click);
            // 
            // InsertBefore
            // 
            this.InsertBefore.Location = new System.Drawing.Point(136, 16);
            this.InsertBefore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertBefore.Name = "InsertBefore";
            this.InsertBefore.Size = new System.Drawing.Size(93, 62);
            this.InsertBefore.TabIndex = 4;
            this.InsertBefore.Text = "Insert Before";
            this.InsertBefore.UseVisualStyleBackColor = true;
            this.InsertBefore.Click += new System.EventHandler(this.InsertBefore_Click);
            // 
            // CreateCircularLinkedList
            // 
            this.CreateCircularLinkedList.Location = new System.Drawing.Point(17, 174);
            this.CreateCircularLinkedList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateCircularLinkedList.Name = "CreateCircularLinkedList";
            this.CreateCircularLinkedList.Size = new System.Drawing.Size(113, 82);
            this.CreateCircularLinkedList.TabIndex = 3;
            this.CreateCircularLinkedList.Text = "Create CircularLinkedList";
            this.CreateCircularLinkedList.UseVisualStyleBackColor = true;
            this.CreateCircularLinkedList.Click += new System.EventHandler(this.CreateCircularLinkedList_Click);
            // 
            // CreateDoubly
            // 
            this.CreateDoubly.Location = new System.Drawing.Point(17, 82);
            this.CreateDoubly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateDoubly.Name = "CreateDoubly";
            this.CreateDoubly.Size = new System.Drawing.Size(113, 85);
            this.CreateDoubly.TabIndex = 2;
            this.CreateDoubly.Text = "Create DoublyLinkedList";
            this.CreateDoubly.UseVisualStyleBackColor = true;
            this.CreateDoubly.Click += new System.EventHandler(this.CreateDoubly_Click);
            // 
            // CreateLinkedList
            // 
            this.CreateLinkedList.Location = new System.Drawing.Point(17, 16);
            this.CreateLinkedList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateLinkedList.Name = "CreateLinkedList";
            this.CreateLinkedList.Size = new System.Drawing.Size(113, 62);
            this.CreateLinkedList.TabIndex = 0;
            this.CreateLinkedList.Text = "Create LinkedList";
            this.CreateLinkedList.UseVisualStyleBackColor = true;
            this.CreateLinkedList.Click += new System.EventHandler(this.CreateLinkedList_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.textBox1);
            this.tabPage8.Controls.Add(this.BinaryMax);
            this.tabPage8.Controls.Add(this.BinaryMin);
            this.tabPage8.Controls.Add(this.button6);
            this.tabPage8.Controls.Add(this.button5);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(528, 341);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "BinarySearchTree";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            // 
            // BinaryMax
            // 
            this.BinaryMax.Location = new System.Drawing.Point(79, 153);
            this.BinaryMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BinaryMax.Name = "BinaryMax";
            this.BinaryMax.Size = new System.Drawing.Size(59, 50);
            this.BinaryMax.TabIndex = 9;
            this.BinaryMax.Text = "Max";
            this.BinaryMax.UseVisualStyleBackColor = true;
            this.BinaryMax.Click += new System.EventHandler(this.BinaryMax_Click);
            // 
            // BinaryMin
            // 
            this.BinaryMin.Location = new System.Drawing.Point(24, 153);
            this.BinaryMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BinaryMin.Name = "BinaryMin";
            this.BinaryMin.Size = new System.Drawing.Size(59, 50);
            this.BinaryMin.TabIndex = 8;
            this.BinaryMin.Text = "Min";
            this.BinaryMin.UseVisualStyleBackColor = true;
            this.BinaryMin.Click += new System.EventHandler(this.BinaryMin_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(229, 53);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 41);
            this.button6.TabIndex = 3;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 25);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 69);
            this.button5.TabIndex = 2;
            this.button5.Text = "Create BinarySearchTree";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.CreateQuadraticHash);
            this.tabPage9.Controls.Add(this.CreateLinearHash);
            this.tabPage9.Controls.Add(this.CreateBucketHash);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(528, 341);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Hashes";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // CreateQuadraticHash
            // 
            this.CreateQuadraticHash.Location = new System.Drawing.Point(12, 167);
            this.CreateQuadraticHash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateQuadraticHash.Name = "CreateQuadraticHash";
            this.CreateQuadraticHash.Size = new System.Drawing.Size(116, 71);
            this.CreateQuadraticHash.TabIndex = 2;
            this.CreateQuadraticHash.Text = "Create QuadraticHash";
            this.CreateQuadraticHash.UseVisualStyleBackColor = true;
            this.CreateQuadraticHash.Click += new System.EventHandler(this.CreateQuadraticHash_Click);
            // 
            // CreateLinearHash
            // 
            this.CreateLinearHash.Location = new System.Drawing.Point(12, 91);
            this.CreateLinearHash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateLinearHash.Name = "CreateLinearHash";
            this.CreateLinearHash.Size = new System.Drawing.Size(116, 71);
            this.CreateLinearHash.TabIndex = 1;
            this.CreateLinearHash.Text = "Create LinearHash";
            this.CreateLinearHash.UseVisualStyleBackColor = true;
            this.CreateLinearHash.Click += new System.EventHandler(this.CreateLinearHash_Click);
            // 
            // CreateBucketHash
            // 
            this.CreateBucketHash.Location = new System.Drawing.Point(12, 14);
            this.CreateBucketHash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateBucketHash.Name = "CreateBucketHash";
            this.CreateBucketHash.Size = new System.Drawing.Size(116, 71);
            this.CreateBucketHash.TabIndex = 0;
            this.CreateBucketHash.Text = "Create BucketHash";
            this.CreateBucketHash.UseVisualStyleBackColor = true;
            this.CreateBucketHash.Click += new System.EventHandler(this.CreateBucketHash_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(567, 14);
            this.ResultBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultBox.Size = new System.Drawing.Size(320, 323);
            this.ResultBox.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(721, 342);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "Empty output";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AllButton
            // 
            this.AllButton.Location = new System.Drawing.Point(567, 343);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(148, 35);
            this.AllButton.TabIndex = 9;
            this.AllButton.Text = "Execute All";
            this.AllButton.UseVisualStyleBackColor = true;
            this.AllButton.Click += new System.EventHandler(this.AllButton_Click);
            // 
            // FormAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 395);
            this.Controls.Add(this.AllButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAD";
            this.Text = "FormAD";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage5;
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
        private new System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button CreateLinkedList;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BinaryMax;
        private System.Windows.Forms.Button BinaryMin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button CreateBucketHash;
        private System.Windows.Forms.Button CreateQuadraticHash;
        private System.Windows.Forms.Button CreateLinearHash;
        private System.Windows.Forms.Button CreateDoubly;
        private System.Windows.Forms.Button CreateCircularLinkedList;
        private System.Windows.Forms.Button CreateStack;
        private System.Windows.Forms.Button CreatePriorityQueue;
        private System.Windows.Forms.Button CreateQueue;
        private System.Windows.Forms.Button InsertAfter;
        private System.Windows.Forms.Button InsertBefore;
        private System.Windows.Forms.Button ShowNext;
        private System.Windows.Forms.TextBox IteratorShow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button AllButton;
    }
}