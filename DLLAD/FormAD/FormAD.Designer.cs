﻿namespace DLLAD
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CreateQueue = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CreateStack = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CreatePriorityQueue = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.CreateLinkedList = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.CreateDoubly = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BinaryMax = new System.Windows.Forms.Button();
            this.BinaryMin = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.CreateBucketHash = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage9);
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
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(374, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ArrayList";
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(120, 288);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 23);
            this.Show.TabIndex = 9;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
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
            // BinarySearch
            // 
            this.BinarySearch.Location = new System.Drawing.Point(251, 35);
            this.BinarySearch.Name = "BinarySearch";
            this.BinarySearch.Size = new System.Drawing.Size(113, 50);
            this.BinarySearch.TabIndex = 5;
            this.BinarySearch.Text = "BinarySearch";
            this.BinarySearch.UseVisualStyleBackColor = true;
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(306, 165);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(58, 50);
            this.Max.TabIndex = 7;
            this.Max.Text = "Max";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(251, 7);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 22);
            this.SearchBox.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Min";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(6, 183);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(95, 50);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Insertion Sort";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // SmartButton
            // 
            this.SmartButton.Location = new System.Drawing.Point(6, 127);
            this.SmartButton.Name = "SmartButton";
            this.SmartButton.Size = new System.Drawing.Size(95, 50);
            this.SmartButton.TabIndex = 2;
            this.SmartButton.Text = "Smart BubbleSort";
            this.SmartButton.UseVisualStyleBackColor = true;
            this.SmartButton.Click += new System.EventHandler(this.SmartButton_Click);
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
            this.tabPage4.Controls.Add(this.CreatePriorityQueue);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(374, 342);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "PriorityQueue";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // CreatePriorityQueue
            // 
            this.CreatePriorityQueue.Location = new System.Drawing.Point(7, 7);
            this.CreatePriorityQueue.Name = "CreatePriorityQueue";
            this.CreatePriorityQueue.Size = new System.Drawing.Size(101, 51);
            this.CreatePriorityQueue.TabIndex = 0;
            this.CreatePriorityQueue.Text = "Create";
            this.CreatePriorityQueue.UseVisualStyleBackColor = true;
            this.CreatePriorityQueue.Click += new System.EventHandler(this.CreatePriorityQueue_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.CreateLinkedList);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(374, 342);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "LinkedList";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // CreateLinkedList
            // 
            this.CreateLinkedList.Location = new System.Drawing.Point(17, 16);
            this.CreateLinkedList.Name = "CreateLinkedList";
            this.CreateLinkedList.Size = new System.Drawing.Size(102, 47);
            this.CreateLinkedList.TabIndex = 0;
            this.CreateLinkedList.Text = "Create LinkedList";
            this.CreateLinkedList.UseVisualStyleBackColor = true;
            this.CreateLinkedList.Click += new System.EventHandler(this.CreateLinkedList_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.CreateDoubly);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(374, 342);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "DoublyLinkedList";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // CreateDoubly
            // 
            this.CreateDoubly.Location = new System.Drawing.Point(17, 20);
            this.CreateDoubly.Name = "CreateDoubly";
            this.CreateDoubly.Size = new System.Drawing.Size(102, 66);
            this.CreateDoubly.TabIndex = 1;
            this.CreateDoubly.Text = "Create DoublyLinkedList";
            this.CreateDoubly.UseVisualStyleBackColor = true;
            this.CreateDoubly.Click += new System.EventHandler(this.button3_Click_1);
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
            this.tabPage8.Controls.Add(this.textBox1);
            this.tabPage8.Controls.Add(this.BinaryMax);
            this.tabPage8.Controls.Add(this.BinaryMin);
            this.tabPage8.Controls.Add(this.button6);
            this.tabPage8.Controls.Add(this.button5);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(374, 342);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "BinarySearchTree";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            // 
            // BinaryMax
            // 
            this.BinaryMax.Location = new System.Drawing.Point(79, 153);
            this.BinaryMax.Name = "BinaryMax";
            this.BinaryMax.Size = new System.Drawing.Size(58, 50);
            this.BinaryMax.TabIndex = 9;
            this.BinaryMax.Text = "Max";
            this.BinaryMax.UseVisualStyleBackColor = true;
            this.BinaryMax.Click += new System.EventHandler(this.BinaryMax_Click);
            // 
            // BinaryMin
            // 
            this.BinaryMin.Location = new System.Drawing.Point(24, 153);
            this.BinaryMin.Name = "BinaryMin";
            this.BinaryMin.Size = new System.Drawing.Size(58, 50);
            this.BinaryMin.TabIndex = 8;
            this.BinaryMin.Text = "Min";
            this.BinaryMin.UseVisualStyleBackColor = true;
            this.BinaryMin.Click += new System.EventHandler(this.BinaryMin_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(229, 80);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 66);
            this.button5.TabIndex = 2;
            this.button5.Text = "Create BinarySearchTree";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.CreateBucketHash);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(374, 342);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "BucketHash";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // CreateBucketHash
            // 
            this.CreateBucketHash.Location = new System.Drawing.Point(69, 42);
            this.CreateBucketHash.Name = "CreateBucketHash";
            this.CreateBucketHash.Size = new System.Drawing.Size(116, 71);
            this.CreateBucketHash.TabIndex = 0;
            this.CreateBucketHash.Text = "Create BucketHash";
            this.CreateBucketHash.UseVisualStyleBackColor = true;
            this.CreateBucketHash.Click += new System.EventHandler(this.CreateBucketHash_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(567, 13);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultBox.Size = new System.Drawing.Size(320, 323);
            this.ResultBox.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(567, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(320, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "Empty output";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 395);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAD";
            this.Text = "FormAD";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
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
        private System.Windows.Forms.Button CreateQueue;
        private System.Windows.Forms.Button CreateStack;
        private System.Windows.Forms.Button CreatePriorityQueue;
        private new System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button CreateLinkedList;
        private System.Windows.Forms.Button CreateDoubly;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BinaryMax;
        private System.Windows.Forms.Button BinaryMin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button CreateBucketHash;
    }
}