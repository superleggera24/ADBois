namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateButton = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.StackButton = new System.Windows.Forms.RadioButton();
            this.QueueButton = new System.Windows.Forms.RadioButton();
            this.ArrayButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sort = new System.Windows.Forms.Button();
            this.RadioInsert = new System.Windows.Forms.RadioButton();
            this.RadioBubble = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NumberTextBox = new System.Windows.Forms.NumericUpDown();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SeqSearchRadio = new System.Windows.Forms.RadioButton();
            this.Counter = new System.Windows.Forms.Label();
            this.ArrayTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinValue = new System.Windows.Forms.Label();
            this.MaxValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CreateButton);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.StackButton);
            this.panel1.Controls.Add(this.QueueButton);
            this.panel1.Controls.Add(this.ArrayButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 115);
            this.panel1.TabIndex = 0;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(121, 4);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 102);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(4, 85);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // StackButton
            // 
            this.StackButton.AutoSize = true;
            this.StackButton.Location = new System.Drawing.Point(4, 58);
            this.StackButton.Name = "StackButton";
            this.StackButton.Size = new System.Drawing.Size(64, 21);
            this.StackButton.TabIndex = 2;
            this.StackButton.TabStop = true;
            this.StackButton.Text = "Stack";
            this.StackButton.UseVisualStyleBackColor = true;
            // 
            // QueueButton
            // 
            this.QueueButton.AutoSize = true;
            this.QueueButton.Location = new System.Drawing.Point(4, 31);
            this.QueueButton.Name = "QueueButton";
            this.QueueButton.Size = new System.Drawing.Size(72, 21);
            this.QueueButton.TabIndex = 1;
            this.QueueButton.TabStop = true;
            this.QueueButton.Text = "Queue";
            this.QueueButton.UseVisualStyleBackColor = true;
            // 
            // ArrayButton
            // 
            this.ArrayButton.AutoSize = true;
            this.ArrayButton.Location = new System.Drawing.Point(4, 4);
            this.ArrayButton.Name = "ArrayButton";
            this.ArrayButton.Size = new System.Drawing.Size(63, 21);
            this.ArrayButton.TabIndex = 0;
            this.ArrayButton.TabStop = true;
            this.ArrayButton.Text = "Array";
            this.ArrayButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Sort);
            this.panel2.Controls.Add(this.RadioInsert);
            this.panel2.Controls.Add(this.RadioBubble);
            this.panel2.Location = new System.Drawing.Point(12, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 60);
            this.panel2.TabIndex = 5;
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(121, 4);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(75, 48);
            this.Sort.TabIndex = 4;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // RadioInsert
            // 
            this.RadioInsert.AutoSize = true;
            this.RadioInsert.Location = new System.Drawing.Point(4, 31);
            this.RadioInsert.Name = "RadioInsert";
            this.RadioInsert.Size = new System.Drawing.Size(90, 21);
            this.RadioInsert.TabIndex = 1;
            this.RadioInsert.TabStop = true;
            this.RadioInsert.Text = "InsertSort";
            this.RadioInsert.UseVisualStyleBackColor = true;
            // 
            // RadioBubble
            // 
            this.RadioBubble.AutoSize = true;
            this.RadioBubble.Location = new System.Drawing.Point(4, 4);
            this.RadioBubble.Name = "RadioBubble";
            this.RadioBubble.Size = new System.Drawing.Size(99, 21);
            this.RadioBubble.TabIndex = 0;
            this.RadioBubble.TabStop = true;
            this.RadioBubble.Text = "BubbleSort";
            this.RadioBubble.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NumberTextBox);
            this.panel3.Controls.Add(this.SearchButton);
            this.panel3.Controls.Add(this.SeqSearchRadio);
            this.panel3.Location = new System.Drawing.Point(250, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 128);
            this.panel3.TabIndex = 6;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(4, 4);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(199, 22);
            this.NumberTextBox.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(128, 77);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 48);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SeqSearchRadio
            // 
            this.SeqSearchRadio.AutoSize = true;
            this.SeqSearchRadio.Location = new System.Drawing.Point(4, 64);
            this.SeqSearchRadio.Name = "SeqSearchRadio";
            this.SeqSearchRadio.Size = new System.Drawing.Size(99, 21);
            this.SeqSearchRadio.TabIndex = 0;
            this.SeqSearchRadio.TabStop = true;
            this.SeqSearchRadio.Text = "SeqSearch";
            this.SeqSearchRadio.UseVisualStyleBackColor = true;
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Location = new System.Drawing.Point(254, 13);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(0, 17);
            this.Counter.TabIndex = 7;
            // 
            // ArrayTextbox
            // 
            this.ArrayTextbox.Location = new System.Drawing.Point(542, 16);
            this.ArrayTextbox.Multiline = true;
            this.ArrayTextbox.Name = "ArrayTextbox";
            this.ArrayTextbox.ReadOnly = true;
            this.ArrayTextbox.Size = new System.Drawing.Size(235, 296);
            this.ArrayTextbox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // MinValue
            // 
            this.MinValue.AutoSize = true;
            this.MinValue.Location = new System.Drawing.Point(13, 298);
            this.MinValue.Name = "MinValue";
            this.MinValue.Size = new System.Drawing.Size(46, 17);
            this.MinValue.TabIndex = 12;
            this.MinValue.Text = "label1";
            // 
            // MaxValue
            // 
            this.MaxValue.AutoSize = true;
            this.MaxValue.Location = new System.Drawing.Point(130, 298);
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.Size = new System.Drawing.Size(46, 17);
            this.MaxValue.TabIndex = 13;
            this.MaxValue.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxValue);
            this.Controls.Add(this.MinValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArrayTextbox);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton StackButton;
        private System.Windows.Forms.RadioButton QueueButton;
        private System.Windows.Forms.RadioButton ArrayButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.RadioButton RadioInsert;
        private System.Windows.Forms.RadioButton RadioBubble;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RadioButton SeqSearchRadio;
        private System.Windows.Forms.NumericUpDown NumberTextBox;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.TextBox ArrayTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MinValue;
        private System.Windows.Forms.Label MaxValue;
        private System.Windows.Forms.Label label1;
    }
}

