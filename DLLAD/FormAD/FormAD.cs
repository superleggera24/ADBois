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
        public RandStack<AD.Players> PlayerStack = new RandStack<AD.Players>();
        public RandQueue<AD.Players> PlayerQueue = new RandQueue<AD.Players>();
        public RandPriorityQueue<int, AD.Players> PlayerPriorityQueue = new RandPriorityQueue<int, AD.Players>();
        public RandLinkedList<AD.Players> PlayerLinkedList = new RandLinkedList<AD.Players>();
        public DoublyLinkedList<AD.Players> PlayerDoublyLinkedList = new DoublyLinkedList<AD.Players>();
        public CircularLinkedList<AD.Players> PlayerCircularLinkedList = new CircularLinkedList<AD.Players>();
        public BinarySearchTree<AD.Players> PlayerBinarySearchTree = new BinarySearchTree<AD.Players>();
        public static BucketHash<AD.Players> PlayerBucketHash = new BucketHash<AD.Players>();
        public static LinearHash<AD.Players> PlayerLinearHash = new LinearHash<AD.Players>();
        public static QuadraticHash<AD.Players> PlayerQuadraticHash = new QuadraticHash<AD.Players>();
        public static BinaryNode<AD.Players> PlayerBinaryNode = new BinaryNode<AD.Players>();
        public Iterator<AD.Players> PlayerIterator;

        static bool ArrayCreated = false;
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
                build.AppendFormat("{2}{0} in: {1}. {2}", method, time, Environment.NewLine);
            } 
            else if (action == 2)
            {
                if (!(output.Contains("=") || !(duration > 0)))
                {
                    build.AppendFormat("{2}{0} found in: {1}. {2}Found at: {3}. {2}", method, time, Environment.NewLine, output);
                }
                else
                {
                    build.AppendFormat("Something went wrong, try another input" + Environment.NewLine);
                }
            }
            else if (action == 3)
            {
                build.AppendFormat("{2}{0} in: {1}.{2}", method, duration, Environment.NewLine);
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
            LinkedList();
        }

        private void CreateCircularLinkedList_Click(object sender, EventArgs e)
        {
            CircularList();
        }

        public static string GetPlayerStats(AD.Players player)
        {
            string stats = null;
            
                stats += "ID";
                stats += player.GetId().ToString();
                stats += "Name: ";
                stats += player.GetName();
                stats += ", Highscore: ";
                stats += player.GetScore().ToString();
                stats += Environment.NewLine;

            return stats;
        }
        
        private void CreateQueue_Click_1(object sender, EventArgs e)
        {
            Queue();
        }

        private void CreatePriorityQueue_Click_1(object sender, EventArgs e)
        {
            PQueue();
        }

        private void CreateStack_Click(object sender, EventArgs e)
        {
            Stack();
        }

        private void CreateBucketHash_Click(object sender, EventArgs e)
        {
            BucketHash();
        }

        private void CreateLinearHash_Click(object sender, EventArgs e)
        {
            LinearHash();
        }

        private void CreateQuadraticHash_Click(object sender, EventArgs e)
        {
            QuadraticHash();
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
            ArrayCreated = true;
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
                PlayerPriorityQueue.Enqueue(priority, player);
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
            if (answer != null)
            {
                answer = player.GetId().ToString();
            }
            else
            {
                answer = "Key could not be found";
            }
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
            SmartBubbleSort();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayMin();
        }

        private void Max_Click(object sender, EventArgs e)
        {
            ArrayMax();
        }

        private void CreateDoubly_Click(object sender, EventArgs e)
        {
            DoublyList();
        }

        //onderstaande event handler zorgt dat het veld van de resultaten leeg is, zodat op dat moment overbodige informatie weg gaat.
        private void button4_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BinarySearchTree();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchBinaryTreeMethod();
        }

        private void BinaryMin_Click(object sender, EventArgs e)
        {
            BinaryMinMethod();
        }

        private void BinaryMax_Click(object sender, EventArgs e)
        {
            BinaryMaxMethod();
        }

        private void BubbleButton_Click(object sender, EventArgs e)
        {
            BubbleSort();
        }

        private void SeqSearch_Click(object sender, EventArgs e)
        {
            SequentialSearchMethod();
        }
        
        private void BinarySearch_Click(object sender, EventArgs e)
        {
            BinarySearchMethod();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            InsertSort();
        }

        // oorspronkelijk bedoeld om te testen, maar we hebben onderstaande methode erin gelaten omdat hij achteraf ook voor toekomstige gebruikers
        // wel handig leek. Het laat de array, waar zoekmethoden en sorteermethoden op kunnen worden losgelaten, zien in zijn huidige staat. 
        // Op deze manier valt te zien of de methoden werken.
        private string ShowArray()
        {
            string ShowResult = ("Make an Array first!" + Environment.NewLine);
            if (_RandomArray[0] != null)
            {
                ShowResult = "";
                foreach (AD.Players player in _RandomArray)
                {
                    ShowResult += player.GetId().ToString();
                    ShowResult += " ";
                    ShowResult += player.GetName();
                    ShowResult += " ";
                    ShowResult += player.GetScore().ToString();
                    ShowResult += Environment.NewLine;
                }
            }
            return ShowResult;
        }

        private void Show_Click(object sender, EventArgs e)
        {
            ResultBox.Text += ShowArray();
        }

        // Voeg random player voor geselecteerde node.
        private void InsertBefore_Click(object sender, EventArgs e)
        {
            // InsertBefore;
            IteratorShow.Text += "Random Player ingevoerd voor de geselecteerde node.";
        }

        // Voeg random player in na geselecteerde node.
        private void InsertAfter_Click(object sender, EventArgs e)
        {
            // InsertAfter;
            IteratorShow.Text += "Random Player ingevoerd na de geselecteerde node.";
        }

        // Laat volgende node zien.
        private void ShowNext_Click(object sender, EventArgs e)
        {
            PlayerIterator.NextLink();
            Node<AD.Players> node = PlayerIterator.GetCurrent();
            AD.Players player = node.data;
            IteratorShow.Text = GetPlayerStats(player);
        }

        //empty Iterator Show screen
        private void button3_Click(object sender, EventArgs e)
        {
            IteratorShow.Text = "";
        }

        private void AllButton_Click(object sender, EventArgs e)
        {
            CreateArray(PlayerBase);
            BubbleSort();
            CreateArray(PlayerBase);
            InsertSort();
            CreateArray(PlayerBase);
            SmartBubbleSort();
            ArrayMax();
            ArrayMin();
            string number = RandomNo(10).ToString();
            SearchBox.Text = number;
            textBox1.Text = number;
            BinarySearchMethod();
            SequentialSearchMethod();
            Array();
            Queue();
            Stack();
            PQueue();

            LinkedList();
            DoublyList();
            CircularList();
            BinarySearchTree();
            BinaryMaxMethod();
            BinaryMinMethod();
            SearchBinaryTreeMethod();

            BucketHash();
            LinearHash();
            QuadraticHash();
        }

        // All the sort methods
        private void BubbleSort()
        {
            if (ArrayCreated == true)
            {
                QPCounter.Start();
                _RandomArray = AD.Sort.BubbleSort<AD.Players>.Sort(_RandomArray);
                QPCounter.Stop();
                double duration = QPCounter.Duration(size);
                ResultBox.Text += Logger("Bubblesorted", duration, null, null, 1);
            }
            else
            {
                ResultBox.Text += "Create an array first!" + Environment.NewLine;
            }
        }
        private void InsertSort()
        {
            if (ArrayCreated == true)
            {
                QPCounter.Start();
                AD.Sort.InsertSort<AD.Players>.InsertSortArrayList(_RandomArray);
                QPCounter.Stop();
                double duration = QPCounter.Duration(size);
                ResultBox.Text += Logger("InsertSorted", duration, null, null, 1);
            }
            else
            {
                ResultBox.Text += "Create an array first!" + Environment.NewLine;
            }
        }

        private void SmartBubbleSort()
        {
            if (ArrayCreated == true)
            {
                QPCounter.Start();
                _RandomArray = AD.Sort.SmartBubbleSort<AD.Players>.Sort(_RandomArray);
                QPCounter.Stop();
                double duration = QPCounter.Duration(size);
                ResultBox.Text += Logger("SmartBubbleSorted", duration, null, null, 3);
            }
            else
            {
                ResultBox.Text += "Create an array first!" + Environment.NewLine;
            }
        }

        // All search methods
        private void ArrayMax()
        {
            QPCounter.Start();
            AD.Players player = AD.Search.Max<AD.Players>.Search(_RandomArray);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            string playerId = player.GetId().ToString();
            if (ArrayCreated == false)
            {
                playerId = "Create an Array First!";
            }
            ResultBox.Text += Logger("Max in array", duration, player, playerId, 2);
        }

        private void ArrayMin()
        {
            QPCounter.Start();
            AD.Players player = AD.Search.Min<AD.Players>.Search(_RandomArray);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            string playerId = player.GetId().ToString();
            if (ArrayCreated == false)
            {
                playerId = "Create an Array First!";
            }
            ResultBox.Text += Logger("Min in array", duration, player, playerId, 2);
        }

        private void BinarySearchMethod()
        {
            int Answer = 0;
            if (SearchBox.Text != "")
            {
                int number = Convert.ToInt32(SearchBox.Text);
                string output = "";
                if (ArrayCreated == true)
                {
                    QPCounter.Start();
                    Answer = AD.Search.BinarySearch<AD.Players>.binSearch(_RandomArray, number);
                    QPCounter.Stop();
                    output = Answer.ToString();
                }
                else
                {
                    output = "Create an Array first!" + Environment.NewLine;
                }
                double duration = QPCounter.Duration(Answer);
                ResultBox.Text += Logger(number.ToString(), duration, null, output, 2);
            }
            else
            {
                ResultBox.Text += "Insert a number in the textbox first please." + Environment.NewLine;
            }
        }
        private void SequentialSearchMethod()
        {
            if (SearchBox.Text != "")
            {
                if (ArrayCreated == true)
                {
                    int number = Convert.ToInt32(SearchBox.Text);
                    QPCounter.Start();
                    int Answer = AD.Search.SequentialSearch<AD.Players>.SeqSearch(_RandomArray, number);
                    QPCounter.Stop();
                    ResultBox.Text += Logger(number.ToString(), QPCounter.Duration(Answer), null, Answer.ToString(), 2);
                }
                else
                {
                    ResultBox.Text += "Create an array first!" + Environment.NewLine;
                }
            }
            else
            {
                ResultBox.Text += "Insert a number in the textbox please!" + Environment.NewLine;
            }
        }
        private void BinaryMaxMethod()
        {
            AD.Players player;
            QPCounter.Start();
            player = MaxBinSearch();
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("Max in Binary", duration, player, player.GetId().ToString(), 2);
        }
        private void BinaryMinMethod()
        {
            AD.Players player;
            QPCounter.Start();
            player = MinBinSearch();
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("Min in Binary", duration, player, player.GetId().ToString(), 2);
        }
        private void SearchBinaryTreeMethod()
        {
            QPCounter.Start();
            string answer = FormBinarySearch(Convert.ToInt32(textBox1.Text));
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            if (answer == null)
            {
                answer = "Create an Array first!" + Environment.NewLine;
            }
            ResultBox.Text += Logger("BinarySearch", duration, null, answer, 2);
        }

        // CollectionCreations
        private void Array()
        {
            QPCounter.Start();
            CreateArray(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += Logger("ArrayCreation", QPCounter.Duration(size), null, null, 1);
        }

        private void Stack()
        {
            QPCounter.Start();
            StackCreation(PlayerBase);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("StackCreation", duration, null, null, 1);
        }
        
        private void Queue()
        {
            QPCounter.Start();
            QueueCreation(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += Logger("QueueCreation", QPCounter.Duration(size), null, null, 1);
        }

        private void PQueue()
        {
            QPCounter.Start();
            CreatePQueue(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += Logger("PriorityQueueCreation", QPCounter.Duration(size), null, null, 1);
        }

        private void LinkedList()
        {
            QPCounter.Start();
            LinkedListCreation(PlayerBase);
            QPCounter.Stop();
            PlayerIterator = new Iterator<AD.Players>(PlayerLinkedList);
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("LinkedList", duration, null, null, 1);
        }

        private void DoublyList()
        {
            QPCounter.Start();
            DoublyListCreation(PlayerBase);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("DoublyLinkedList", duration, null, null, 1);
        }

        private void CircularList()
        {
            QPCounter.Start();
            CircularLinkedListCreation(PlayerBase);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("CircularLinkedList", duration, null, null, 1);
        }

        private void BinarySearchTree()
        {
            QPCounter.Start();
            CreateBinarySearchTree(PlayerBase);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("BinarySearchTree", duration, null, null, 1);
        }

        private void BucketHash()
        {
            QPCounter.Start();
            BucketHashCreation(PlayerBase);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("BucketHash Creation", duration, null, null, 1);
        }

        private void LinearHash()
        {
            QPCounter.Start();
            LinearHashCreation(PlayerBase);
            QPCounter.Stop();
            double duration = QPCounter.Duration(size);
            ResultBox.Text += Logger("LinearHash Creation", duration, null, null, 1);
        }

        private void QuadraticHash()
        {
            QPCounter.Start();
            QuadraticHashCreation(PlayerBase);
            QPCounter.Stop();
            ResultBox.Text += Logger("QuadraticHash Creation", QPCounter.Duration(size), null, null, 1);
        }
    }
}
