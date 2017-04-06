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
        // Here the different collections are initiated for future use in the code
        public static List<AD.Players> PlayerBase = PlayerList<AD.Players>.PlayerBase;
        public static AD.Players[] _RandomArray = new AD.Players[300];
        public static RandStack<AD.Players> PlayerStack = new RandStack<AD.Players>();
        public static RandQueue<AD.Players> PlayerQueue = new RandQueue<AD.Players>();
        public static RandLinkedList<AD.Players> PlayerLinkedList = new RandLinkedList<AD.Players>();
        public static DoublyLinkedList<AD.Players> PlayerDoublyLinkedList = new DoublyLinkedList<AD.Players>();
        public static BinarySearchTree<AD.Players> PlayerBinarySearchTree = new BinarySearchTree<AD.Players>();
        public static BinaryNode<AD.Players> PlayerBinaryNode = new BinaryNode<AD.Players>();

        static Random random = new Random();
        static Random rnd = new Random();
        public static int size = 300;
        int count = 0;
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
            QPCounter.Start();
            AD.Players player = AD.Search.Max<AD.Players>.Search(_RandomArray);
            QPCounter.Stop();
            ResultBox.Text += "Max found in: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
            ResultBox.Text += player.GetId().ToString();
            ResultBox.Text += " ";
            ResultBox.Text += player.GetName();
            ResultBox.Text += " ";
            ResultBox.Text += player.GetScore().ToString();
            ResultBox.Text += Environment.NewLine;
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
        
        private void CreateQueue_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            QueueCreation(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += "QueueCreation: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
        }

        private void CreatePriorityQueue_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            CreatePQueue(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += "PriorityQueueCreation: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
            //ResultBox.Text += PlayerPriorityQueue.Count.ToString();
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
        private void StackCreation(List<AD.Players> List)
        {
            foreach (AD.Players player in List)
            {
                PlayerStack.push(player);
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

        private void CreatePQueue(List<AD.Players> List)
        {
            int priority = 0;
            foreach (AD.Players player in List)
            {
                priority = RandomNo(2);
                //PlayerPriorityQueue.Enqueue(priority, player);
            }
        }

        private void LinkedListCreation(List<AD.Players> List)
        {
            foreach (AD.Players player in List)
            {
                PlayerLinkedList.AddLast(player);
                
            }
        }

        private void DoublyListCreation(List<AD.Players> List)
        {
            foreach (AD.Players player in List)
            {
                PlayerDoublyLinkedList.Add(player);
            }
        }

        private void CreateBinarySearchTree(List<AD.Players> List)
        {
            int key = 0;
            foreach (AD.Players player in List)
            {
                key = player.GetScore();
                PlayerBinarySearchTree.Insert(player);
            }
        }

        private void BubbleButton_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            _RandomArray = AD.Sort.BubbleSort<AD.Players>.Sort(_RandomArray);
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

        private string ShowArray()
        {
            string ShowResult = "";
            foreach (AD.Players player in _RandomArray)
            {
                ShowResult += player.GetId().ToString();
                ShowResult += " ";
                ShowResult += player.GetName();
                ShowResult += " ";
                ShowResult += player.GetScore().ToString();
                ShowResult += Environment.NewLine;
            }
            return ShowResult;
        }

        public string FormBinarySearch(int key)
        {
            string answer = "";
            //PlayerBinaryNode = BinarySearchTree<int, AD.Players>.FindNode(key);
            AD.Players player = PlayerBinaryNode.Data;
            answer = player.GetId().ToString();
            return answer;
        }

        public AD.Players MaxBinSearch()
        {
            AD.Players player = BinarySearchTree<AD.Players>.FindMax();
            return player;
        }

        public AD.Players MinBinSearch()
        {
            AD.Players player = BinarySearchTree<AD.Players>.FindMin();
            return player;
        }

        // For testing purposes only
        private void Show_Click(object sender, EventArgs e)
        {
            ResultBox.Text += Environment.NewLine;
            ResultBox.Text += ShowArray();
        }

        private void SmartButton_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            _RandomArray = AD.Sort.SmartBubbleSort<AD.Players>.Sort(_RandomArray);
            QPCounter.Stop();
            ResultBox.Text += "SmartBubblesorted in: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
        }

        private void CreateLinkedList_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            LinkedListCreation(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += "LinkedList created in: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
        }

        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            AD.Players player = AD.Search.Min<AD.Players>.Search(_RandomArray);
            QPCounter.Stop();
            ResultBox.Text += "Min found in: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
            ResultBox.Text += player.GetId().ToString();
            ResultBox.Text += " ";
            ResultBox.Text += player.GetName();
            ResultBox.Text += " ";
            ResultBox.Text += player.GetScore().ToString();
            ResultBox.Text += Environment.NewLine;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            QPCounter.Start();
            DoublyListCreation(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += "DoublyLinkedList created in: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            CreateBinarySearchTree(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += "BinarySearchTree created in: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            string answer = "";// = FormBinarySearch(Convert.ToInt32(numericUpDown1.Text));
            QPCounter.Stop();
            ResultBox.Text += "Searched for: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
            ResultBox.Text += answer;
            ResultBox.Text += Environment.NewLine;
        }

        private void BinaryMin_Click(object sender, EventArgs e)
        {
            AD.Players player;
            QPCounter.Start();
            player = MinBinSearch();
            QPCounter.Stop();
            ResultBox.Text += "Min in Binarytree is: ";
            ResultBox.Text += player.GetName();
            ResultBox.Text += " ";
            ResultBox.Text += player.GetScore().ToString();
            ResultBox.Text += Environment.NewLine;
            ResultBox.Text += "Searched for: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
        }

        private void BinaryMax_Click(object sender, EventArgs e)
        {
            AD.Players player;
            QPCounter.Start();
            player = MaxBinSearch();
            QPCounter.Stop();
            ResultBox.Text += "Min in Binarytree is: ";
            ResultBox.Text += player.GetName();
            ResultBox.Text += " ";
            ResultBox.Text += player.GetScore().ToString();
            ResultBox.Text += Environment.NewLine;
            ResultBox.Text += "Searched for: ";
            ResultBox.Text += QPCounter.Duration(size).ToString();
            ResultBox.Text += Environment.NewLine;
        }
    }
}
