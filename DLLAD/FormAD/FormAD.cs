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
        // Hier worden de verschillende collecties aangemaakt zodat zij later kunnen worden aangeroepen in code.
        public static List<AD.Players> PlayerBase = PlayerList<AD.Players>.PlayerBase;
        public static AD.Players[] _RandomArray = new AD.Players[300];
        public static RandStack<AD.Players> PlayerStack = new RandStack<AD.Players>();
        public static RandQueue<AD.Players> PlayerQueue = new RandQueue<AD.Players>();
        public static RandLinkedList<AD.Players> PlayerLinkedList = new RandLinkedList<AD.Players>();
        public static DoublyLinkedList<AD.Players> PlayerDoublyLinkedList = new DoublyLinkedList<AD.Players>();
        public static CircularLinkedList<AD.Players> PlayerCircularLinkedList = new CircularLinkedList<AD.Players>();
        public static BinarySearchTree<AD.Players> PlayerBinarySearchTree = new BinarySearchTree<AD.Players>();
        public static BucketHash<AD.Players> PlayerBucketHash = new BucketHash<AD.Players>();
        public static LinearHash<AD.Players> PlayerLinearHash = new LinearHash<AD.Players>();
        public static QuadraticHash<AD.Players> PlayerQuadraticHash = new QuadraticHash<AD.Players>();
        public static BinaryNode<AD.Players> PlayerBinaryNode = new BinaryNode<AD.Players>();

        static Random random = new Random();
        static Random rnd = new Random();
        public static int size = 300;
        private AD.QueryPerfCounter QPCounter = new AD.QueryPerfCounter();

        // Methode waarmee makkelijker gelogd kan worden. Dit zorgt ervoor dat er minder code per event-handler geschreven hoeft te worden.
        // De verschillende vormen zijn: 
        // 1: creaties
        // 2: zoeken
        // 3: sorteren
        public string Logger(string method, double duration, AD.Players player, string output, int action)
        {
            StringBuilder build = new StringBuilder();
            string time = duration.ToString();
            if (action == 1)
            {
                build.AppendFormat("{0} in: {1}. {2}", method, time, Environment.NewLine);
            } 
            else if (action == 2)
            {
                build.AppendFormat("{0} found in: {1}. {2}Found at: {3}. {2}", method, time, Environment.NewLine, output);
            }
            else if (action == 3)
            {
                build.AppendFormat("{0} in: {1}.{2}", method, duration, Environment.NewLine);
            }
            string result = build.ToString();
            return result;
        } 

        // Methode voor het creëeren van een nieuwe speler.
        public void NewPlayer(int Id, string Name, int Score)
        {
            PlayerBase.Add(new AD.Players(Id, Name, Score));
        }

        // Methode voor het creëeren van random nummers.
        public static int RandomNo(int size)
        {
            return rnd.Next(size * 2);
        }
        
        // Methode voor het creëeren van random namen.
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

        // alle eventhandlers voor het creëeren van de verschillende collecties.
        private void button1_Click(object sender, EventArgs e)
        {            
            // De foreach zorgt dat de array gevuld wordt en dat de textbox gevuld wordt.
            QPCounter.Start();
            CreateArray(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += Logger("ArrayCreation", QPCounter.Duration(size), null, null, 1);
        }

        // Methode voor het maken van de basiscollectie, waaruit alle collecties voort komen. Dit om te zorgen dat de data hetzelfde blijft
        // en dus de uitkomsten zo accuraat mogelijk zijn.
        private void ProgramStart()
        {
            QPCounter.Start();
            ListCreation();
            QPCounter.Stop();
            ResultBox.Text += Logger("ListCreation", QPCounter.Duration(size), null, null, 1);
        }

        private void CreateLinkedList_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            LinkedListCreation(PlayerBase);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("LinkedList", duration, null, null, 1);
        }

        private void CreateCircularLinkedList_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            CircularLinkedListCreation(PlayerBase);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("CircularLinkedList", duration, null, null, 1);
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
            ResultBox.Text += Logger("QueueCreation", QPCounter.Duration(size), null, null, 1);
        }

        private void CreatePriorityQueue_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            CreatePQueue(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += Logger("PriorityQueueCreation", QPCounter.Duration(size), null, null, 1);
            //ResultBox.Text += PlayerPriorityQueue.Count.ToString();
        }

        private void CreateStack_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            StackCreation(PlayerBase);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("StackCreation", duration, null, null, 1);
        }

        private void CreateBucketHash_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            BucketHashCreation(PlayerBase);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("BucketHash Creation", duration, null, null, 1);
        }

        private void CreateLinearHash_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            LinearHashCreation(PlayerBase);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("LinearHash Creation", duration, null, null, 1);
        }

        private void CreateQuadraticHash_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            QuadraticHashCreation(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += Logger("QuadraticHash Creation", QPCounter.Duration(size), null, null, 1);
        }

        // Hier zijn alle creatie methoden bij elkaar. Ze worden aangeroepen wanneer er op de betreffende knop wordt gedrukt.
        // Op deze manier zijn de methoden beter gescheiden van de eventhandlers en wordt de code een stuk overzichtelijker

        public void ListCreation() //Dit is de basislijst welke wordt gestart met het programma. Op deze manier blijven de gegevens gelijk.
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

        //creatie van onze stack.
        private void StackCreation(List<AD.Players> List) 
        {
            foreach (AD.Players player in List)
            {
                PlayerStack.push(player);
            }
        }

        //creatie van onze Queue.
        private void QueueCreation(List<AD.Players> List)
        {
            foreach (AD.Players player in List)
            {
                PlayerQueue.Enqueue(player);
            }
        }

        //creatie van onze Array.
        private void CreateArray(List<AD.Players> List)
        {
            int count = 0;
            foreach (AD.Players player in PlayerBase)
            {
                _RandomArray[count] = player;
                count++;
            }
        }
        
        //creatie van een priorityqueue. Er wordt met random nummers een prioriteit gesimuleerd.
        private void CreatePQueue(List<AD.Players> List)
        {
            int priority = 0;
            foreach (AD.Players player in List)
            {
                priority = RandomNo(2);
                //PlayerPriorityQueue.Enqueue(priority, player);
            }
        }
        
        //creatie van een linkedlist.
        private void LinkedListCreation(List<AD.Players> List)
        {
            foreach (AD.Players player in List)
            {
                PlayerLinkedList.AddLast(player);
            }
        }

        //creatie van een doublylinkedlist.
        private void DoublyListCreation(List<AD.Players> List)
        {
            foreach (AD.Players player in List)
            {
                PlayerDoublyLinkedList.Add(player);
            }
        }

        private void CircularLinkedListCreation(List<AD.Players> List)
        {
            foreach (AD.Players player in List)
            {
                PlayerCircularLinkedList.InsertFirst(player);
            }
        }

        //creatie van een BinarySearchTree. Hier moet een key waarde bij om te weten waar de (in dit geval) player komt te staan. 
        //we hebben daar onze highscore voor gebruikt.
        private void CreateBinarySearchTree(List<AD.Players> List)
        {
            int key = 0;
            foreach (AD.Players player in List)
            {
                key = player.GetScore();
                PlayerBinarySearchTree.Insert(player);
            }
        }

        // creatie van een BucketHash. Om een hashbare string te krijgen hebben we gebruik gemaakt van een nieuwe klasse.
        // deze klasse is te vinden in Collections.BucketHash.cs. Daar staat ook verdere uitleg.
        private void BucketHashCreation(List<AD.Players> List)
        {
            string value = "";
            foreach (AD.Players player in List)
            {
                value = player.GetName();
                PlayerBucketHash.AddItem(player, value);
            }
        }

        private void LinearHashCreation(List<AD.Players> List)
        {
            string value = "";
            foreach (AD.Players player in List)
            {
                value = player.GetName();
                PlayerLinearHash.AddItem(player, value);
            }
        }

        private void QuadraticHashCreation(List<AD.Players> List)
        {
            string value = "";
            foreach (AD.Players player in List)
            {
                value = player.GetName();
                
            }
        }

        // Methoden van de verschillende zoekmethoden.
        public string FormBinarySearch(int key)
        {
            string answer = "";
            PlayerBinaryNode = BinarySearchTree<AD.Players>.Find(key);
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

        // Hier dan alle eventhandlers voor de sorteer- en zoekmethoden.
        private void SmartButton_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            _RandomArray = AD.Sort.SmartBubbleSort<AD.Players>.Sort(_RandomArray);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("SmartBubbleSorted", duration, null, null, 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            AD.Players player = AD.Search.Min<AD.Players>.Search(_RandomArray);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("Min", duration, player, player.GetId().ToString(), 2);
        }

        private void Max_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            AD.Players player = AD.Search.Max<AD.Players>.Search(_RandomArray);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("Max", duration, player, player.GetId().ToString(), 2);
        }

        private void CreateDoubly_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            DoublyListCreation(PlayerBase);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("DoublyLinkedList", duration, null, null, 1);
        }

        //onderstaande event handler zorgt dat het veld van de resultaten leeg is, zodat op dat moment overbodige informatie weg gaat.
        private void button4_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            CreateBinarySearchTree(PlayerBase);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("BinarySearchTree", duration, null, null, 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            string answer = FormBinarySearch(Convert.ToInt32(textBox1.Text));
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("BinarySearch", duration, null, answer, 2);
        }

        private void BinaryMin_Click(object sender, EventArgs e)
        {
            AD.Players player;
            QPCounter.Start();
            player = MinBinSearch();
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("Min in Binary", duration, player, player.GetId().ToString(), 2);
        }

        private void BinaryMax_Click(object sender, EventArgs e)
        {
            AD.Players player;
            QPCounter.Start();
            player = MaxBinSearch();
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("Max in Binary", duration, player, player.GetId().ToString(), 2);
        }

        private void BubbleButton_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            _RandomArray = AD.Sort.BubbleSort<AD.Players>.Sort(_RandomArray);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("Bubblesorted", duration, null, null, 1);
        }

        private void SeqSearch_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(SearchBox.Text);
            QPCounter.Start();
            int Answer = AD.Search.SequentialSearch<AD.Players>.SeqSearch(_RandomArray, number);
            QPCounter.Stop();
            ResultBox.Text += Logger(number.ToString(), QPCounter.Duration(Answer), null, Answer.ToString(), 2);
        }
        
        private void BinarySearch_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(SearchBox.Text);
            QPCounter.Start();
            int Answer = AD.Search.BinarySearch<AD.Players>.binSearch(_RandomArray, number);
            QPCounter.Stop();
            double duration = QPCounter.Duration(Answer);
            ResultBox.Text += Logger(number.ToString(), duration, null, Answer.ToString(), 2);
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            QPCounter.Start();
            AD.Sort.InsertSort<AD.Players>.InsertSortArrayList(_RandomArray);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("InsertSorted", duration, null, null, 1);
        }

        // oorspronkelijk bedoeld om te testen, maar we hebben onderstaande methode erin gelaten omdat hij achteraf ook voor toekomstige gebruikers
        // wel handig leek. Het laat de array, waar zoekmethoden en sorteermethoden op kunnen worden losgelaten, zien in zijn huidige staat. 
        // Op deze manier valt te zien of de methoden werken.
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

        private void Show_Click(object sender, EventArgs e)
        {
            ResultBox.Text += Environment.NewLine;
            ResultBox.Text += ShowArray();
        }
    }
}
