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

namespace DLLAD
{
    
    public partial class FormAD : Form
    {

        public static List<AD.Players> PlayerBase = PlayerList<AD.Players>.PlayerBase;
        public static AD.Players[] _RandomArray = new AD.Players[300];
        public static RandStack<AD.Players> PlayerStack = new RandStack<AD.Players>();
        public static RandQueue<AD.Players> PlayerQueue = new AD.Collections.RandQueue<AD.Players>();

        static Random random = new Random();
        static Random rnd = new Random();
        public static int size = 300;
        private AD.QueryPerfCounter QPCounter = new AD.QueryPerfCounter();

        

        public void NewPlayer(int Id, string Name, int Score)
        {
            PlayerBase.Add(new AD.Players(Id, Name, Score));
        }
        public static int RandomNo(int size)
        {
            
            return rnd.Next(size * 2);
        }
        
        public static string RandomString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            string finalString = new String(stringChars);
            return finalString;
        }

        public FormAD()
        {
            InitializeComponent();
            ProgramStart();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            // De foreach zorgt dat de array gevuld wordt en dat de textbox gevuld wordt.
            QPCounter.Start();
            CreateArray(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += "ArrayCreation: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
        }

        private void Max_Click(object sender, EventArgs e)
        {

        }

        private void ProgramStart()
        {
            QPCounter.Start();
            ListCreation();
            QPCounter.Stop();
            ResultBox.Text += "ListCreation: ";
            ResultBox.Text += QPCounter.Duration(size);
            ResultBox.Text += Environment.NewLine;
        }

        private void CreateList_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            ListCreation();
            QPCounter.Stop();
            ResultBox.Text += "ListCreation: ";
            ResultBox.Text += QPCounter.Duration(size);
            ResultBox.Text += Environment.NewLine;
        }

        public static string GetPlayerStats(List<AD.Players> PlayerBase)
        {
            string stats = null;
            foreach (AD.Players player in PlayerBase)
            {
                stats += "ID";
                stats += player.GetId().ToString();
                stats += "Name: ";
                stats += player.GetName();
                stats += ", Highscore: ";
                stats += player.GetScore().ToString();
                stats += Environment.NewLine;

            }
            return stats;
        }

        public void ListCreation()
        {
            ResultBox.Text = "";
            int ID = 0;
            string Name = "";
            int HScore = 0;


            for (int i = 0; i < size; i++)
            {
                ID = i;
                Name = RandomString();
                HScore = RandomNo(size);

                PlayerBase.Add(new AD.Players(ID, Name, HScore));

            }
        }

        private void CreateQueue_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            QueueCreation(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += "QueueCreation: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
        }

        private void CreateStack_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            StackCreation(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += "StackCreation: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
        }

        // Here all the creation methods are together. They are being called by button presses.
        private void StackCreation(List<AD.Players> List)
        {
            foreach (AD.Players player in List)
            {

                PlayerStack.Push(player);

            }
        }

        private void QueueCreation(List<AD.Players> List)
        {
            foreach (AD.Players player in List)
            {
                PlayerQueue.Enqueue(player);
            }
        }

        private void CreateArray(List<AD.Players> List)
        {
            int count = 0;
            foreach (AD.Players player in PlayerBase)
            {
                _RandomArray[count] = player;
                count++;
            }
        }

        private void BubbleButton_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            AD.Sort.BubbleSort<AD.Players>.Sort(_RandomArray);
            QPCounter.Stop();
            ResultBox.Text += "Bubblesorted in: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
        }

        private void SeqSearch_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(SearchBox.Text);
            
            int Answer = AD.Search.SequentialSearch<AD.Players>.SeqSearch(_RandomArray, number);

            ResultBox.Text += "SeqSearch place: ";
            ResultBox.Text += Answer.ToString();
            ResultBox.Text += "Took: ";
            ResultBox.Text += QPCounter.Duration(Answer).ToString();
            ResultBox.Text += Environment.NewLine;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            AD.Sort.InsertSort<AD.Players>.InsertSortArrayList(_RandomArray);
            QPCounter.Stop();
            ResultBox.Text += "InsertSorted in: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
        }

        private void CreatePriorityQueue_Click(object sender, EventArgs e)
        {

        }
    }
}
