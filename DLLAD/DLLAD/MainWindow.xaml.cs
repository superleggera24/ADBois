using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using AD;
using AD.Collections;

namespace DLLAD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public int[] NumberArray = new int[1000];
        
        QueryPerfCounter QueryCounter = new QueryPerfCounter();
        public MainWindow()
        {

            //int[] NumberArray = new int[1000];
            CreateOnStart(NumberArray);
            InitializeComponent();
        }

        public void CreateOnStart(int[] NumberArray)
        {
            
            int maxRand = NumberArray.Length * 2;
            int min = 0;
            Random randomNo = new Random();
            int count = 0;

            // De foreach zorgt dat de array gevuld wordt en dat de textbox gevuld wordt.
            foreach (int number in NumberArray)
            {
                NumberArray[count] = randomNo.Next(min, maxRand);
                count++;
            }
        }
        // Hiermee wordt gecheckt of het ingevoerde nummer wel een nummer is.
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        // De sort button zorgt ervoor dat de geinitieerde array wordt gesorteerd volgens de bedoelde 
        // methode. Ondertussen zorgt de querycounter ervoor dat de tijdsduur wordt bijgehouden.

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            //RandomCollection = new RandomCollection<T>;
           // if (ArrayButton.IsChecked == true)
           // {
                int[] RandomCollection = RandArray<int>.RandomArray;
            //} else if (QueueButton.IsChecked == true)
            {

            }
            
            Counter.Content = String.Empty;
            label1.Content = "Busy... ";          
            if (radioBubble.IsChecked == true)
            {
                
                ArrayTextbox.Text = String.Empty;
                QueryCounter.Start();
                AD.Sort.BubbleSort.Sort<int>(RandomCollection);
                QueryCounter.Stop();
                for (int count = 0; count <= 10; count++)
                {
                    ArrayTextbox.Text += RandomCollection[count].ToString();
                    ArrayTextbox.Text += Environment.NewLine;
                }
                Counter.Content = QueryCounter.Duration(RandomCollection.Length)/1000000;
                label1.Content = "Done!";
            }
            else if(radioInsert.IsChecked == true)
                {
                ArrayTextbox.Text = String.Empty;
                QueryCounter.Start();
                AD.Sort.InsertSort.InsertSortArrayList(RandomCollection);
                QueryCounter.Stop();
                for (int count = 0; count <= 10; count++)
                {
                    ArrayTextbox.Text += RandomCollection[count].ToString();
                    ArrayTextbox.Text += Environment.NewLine;
                }
                Counter.Content = QueryCounter.Duration(RandomCollection.Length) / 1000000;
                label1.Content = "Done!";
            }
            
        }

        // Maakt een nieuwe random Array om te gebruiken voor het sorteren.
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            MinValue.Content = String.Empty;
            MaxValue.Content = String.Empty;
            ArrayTextbox.Text = String.Empty;
            if (ArrayButton.IsChecked == true)
            {
                AD.Collections.RandArray<int>.InitiateArray(NumberArray);
                
                int[] RandomArray = AD.Collections.RandArray<int>._RandomArray;
                MinValue.Content = AD.Search.Min.MinNumber(RandomArray);
                MaxValue.Content = AD.Search.Max.MaxNumber(RandomArray);
                for (int count = 0; count <= 10; count++)
                {

                    ArrayTextbox.Text += RandomArray[count].ToString();
                    ArrayTextbox.Text += Environment.NewLine;
                }
                label1.Content = "A new array is created!";
            }
            else if (QueueButton.IsChecked == true)
            {
                AD.Collections.RandQueue<int>.InitiateRandQueue(NumberArray);

                Queue<int> RandomQueue = AD.Collections.RandQueue<int>._RandomQueue;
                MinValue.Content = AD.Collections.RandQueue<int>.Lowest;
                MaxValue.Content = AD.Collections.RandQueue<int>.Highest;
                ArrayTextbox.Text = AD.Collections.RandQueue<int>.PeekRandom().ToString();
            }
            else if (StackButton.IsChecked == true)
            {
                AD.Collections.RandStack.InitiateRandStack(NumberArray);

                Stack<int> RandomStack = AD.Collections.RandStack._RandomStack;
                MinValue.Content = RandStack.Lowest;
                MaxValue.Content = RandStack.Highest;
                ArrayTextbox.Text = RandStack.PeekStack().ToString();
            }
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            int inputNumber = Convert.ToInt16(NumberTextBox.Text);
            int[] RandomArray = AD.Collections.RandArray<int>._RandomArray;
            if(SeqSearchRadio.IsChecked == true)
            {
                ArrayTextbox.Text = String.Empty;
                ArrayTextbox.Text = String.Format("Your input {0} is placed at {1}", inputNumber, AD.Search.SequentialSearch.SeqSearch(RandomArray, inputNumber));
            }
        }

        private void RadioMax_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
