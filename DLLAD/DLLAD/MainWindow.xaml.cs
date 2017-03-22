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
        QueryPerfCounter QueryCounter = new QueryPerfCounter();
        public MainWindow()
        {
            InitializeComponent();
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
            int[] RandomArray = AD.Collections.RandArray.RandomArray;
            Counter.Content = String.Empty;
            label1.Content = "Busy... ";          
            if (radioBubble.IsChecked == true)
            {
                
                ArrayTextbox.Text = String.Empty;
                QueryCounter.Start();
                BubbleSort.BubbleSortArrayList<int>(RandomArray);
                QueryCounter.Stop();
                for (int count = 0; count <= 10; count++)
                {
                    ArrayTextbox.Text += RandomArray[count].ToString();
                    ArrayTextbox.Text += Environment.NewLine;
                }
                Counter.Content = QueryCounter.Duration(RandomArray.Length)/1000000;
                label1.Content = "Done!";
            }
            else if(radioInsert.IsChecked == true)
                {
                ArrayTextbox.Text = String.Empty;
                QueryCounter.Start();
                InsertSort.InsertSortArrayList(RandomArray);
                QueryCounter.Stop();
                for (int count = 0; count <= 10; count++)
                {
                    ArrayTextbox.Text += RandomArray[count].ToString();
                    ArrayTextbox.Text += Environment.NewLine;
                }
                Counter.Content = QueryCounter.Duration(RandomArray.Length) / 1000000;
                label1.Content = "Done!";
            }
            else if(RadioMin.IsChecked == true)
            {
                ArrayTextbox.Text = String.Empty;
                QueryCounter.Start();
                Min.MinNumber(RandomArray);
                QueryCounter.Stop();
                for (int count = 0; count <= 10; count++)
                {
                    ArrayTextbox.Text += RandomArray[count].ToString();
                    ArrayTextbox.Text += Environment.NewLine;
                }
                Counter.Content = QueryCounter.Duration(RandomArray.Length) / 1000000;
                label1.Content = "Done!";

            }
            else if(RadioBinary.IsChecked == true)
            {

            }
        }

        // Maakt een nieuwe random Array om te gebruiken voor het sorteren.
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            ArrayTextbox.Text = String.Empty;
            if (ArrayButton.IsChecked == true)
            {
                AD.Collections.RandArray.InitiateArray();
                
                int[] RandomArray = AD.Collections.RandArray._RandomArray;
                for(int count = 0; count <= 10; count++)
                {

                    ArrayTextbox.Text += RandomArray[count].ToString();
                    ArrayTextbox.Text += Environment.NewLine;
                }
                label1.Content = "A new array is created!";
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            int inputNumber = Convert.ToInt16(NumberTextBox.Text);
            int[] RandomArray = AD.Collections.RandArray._RandomArray;
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
