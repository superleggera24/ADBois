using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD.Collections;
using AD;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form 
    {
        
        public object[] NumberArray = new object[1000];
        QueryPerfCounter QueryCounter = new QueryPerfCounter();
        public Form1()
        {
            CreateOnStart(NumberArray);
            InitializeComponent();
        }

        public void CreateOnStart(object[] NumberArray)
        {

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            Random randomNo = new Random();
            int count = 0;
            int HS = randomNo.Next(0, 1000);

            foreach (object player in NumberArray)
            {

                NumberArray[count] = new Player<>.Player;
                count++;
            }
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            MinValue.Text = String.Empty;
            MaxValue.Text = String.Empty;
            ArrayTextbox.Text = String.Empty;
            if (ArrayButton.Checked == true)
            {
                AD.Collections.RandArray<int>.InitiateArray(NumberArray);

                int[] RandomArray = AD.Collections.RandArray<int>._RandomArray;
                MinValue.Text = AD.Search.Min.MinNumber(RandomArray).ToString();
                MaxValue.Text = AD.Search.Max.MaxNumber(RandomArray).ToString();
                for (int count = 0; count <= 10; count++)
                {

                    ArrayTextbox.Text += RandomArray[count].ToString();
                    ArrayTextbox.Text += Environment.NewLine;
                }
                label1.Text = "A new array is created!";
            }
            else if (QueueButton.Checked == true)
            {
                //RandQueue<int>.InitiateRandQueue(NumberArray);

                //Queue<int> RandomQueue = RandQueue<int>._RandomQueue;
                //MinValue.Content = RandQueue<int>.Lowest;
                //MaxValue.Content = RandQueue<int>.Highest;
                //ArrayTextbox.Text = RandQueue<int>.PeekRandom().ToString();

                foreach (int number in NumberArray)
                {
                    //AD.Collections.Queue<int>.RandomQueue.Enqueue(number);
                }
            }
            else if (StackButton.Checked == true)
            {
                AD.Collections.RandStack<int>.InitiateRandStack(NumberArray);

                Stack<int> RandomStack = AD.Collections.RandStack<int>._RandomStack;
                MinValue.Text = RandStack<int>.Lowest.ToString();
                MaxValue.Text = RandStack<int>.Highest.ToString();
                ArrayTextbox.Text = RandStack<int>.PeekStack().ToString();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int inputNumber = Convert.ToInt16(NumberTextBox.Text);
            int[] RandomArray = RandArray<int>._RandomArray;
            if (SeqSearchRadio.Checked == true)
            {
                ArrayTextbox.Text = String.Empty;
                ArrayTextbox.Text = String.Format("Your input {0} is placed at {1}", inputNumber, AD.Search.SequentialSearch.SeqSearch(RandomArray, inputNumber));
            }
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            int[] RandomArray = RandArray<int>.RandomArray;

            Counter.Text = String.Empty;
            label1.Text = "Busy... ";
            if (RadioBubble.Checked == true)
            {

                ArrayTextbox.Text = String.Empty;
                QueryCounter.Start();
                AD.Sort.BubbleSort.Sort<int>(RandomArray);
                QueryCounter.Stop();
                double Duration = QueryCounter.Duration(RandomArray.Length);
                Counter.Text = Duration.ToString();
                QueryCounter.Start();
                //AD.Sort.BubbleSort.Sort<int>(RandomStack);
                QueryCounter.Stop();
                for (int count = 0; count <= 10; count++)
                {
                    ArrayTextbox.Text += RandomArray[count].ToString();
                    ArrayTextbox.Text += Environment.NewLine;
                }
                double Duration2 = QueryCounter.Duration(RandomArray.Length);
                Counter.Text = Duration.ToString();
                label1.Text = "Done!";
            }
            else if (RadioInsert.Checked == true)
            {
                ArrayTextbox.Text = String.Empty;
                QueryCounter.Start();
                AD.Sort.InsertSort.InsertSortArrayList(RandomArray);
                QueryCounter.Stop();
                for (int count = 0; count <= 10; count++)
                {
                    ArrayTextbox.Text += RandomArray[count].ToString();
                    ArrayTextbox.Text += Environment.NewLine;
                }
                double Duration = QueryCounter.Duration(RandomArray.Length) / 1000000;
                Counter.Text = Duration.ToString();
                label1.Text = "Done!";
            }
        }
    }
}
