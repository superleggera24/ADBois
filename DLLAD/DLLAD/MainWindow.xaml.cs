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

namespace DLLAD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        int[] RandomArray = new int[1000];
        QueryPerfCounter QueryCounter = new QueryPerfCounter();
        public MainWindow()
        {
            InitializeComponent();
            
            int maxRand = RandomArray.Length * 2;
            int min = 0;
            Random randomNo = new Random();
            int count = 0;

            foreach (int value in RandomArray)
            {
                RandomArray[count] = randomNo.Next(min, maxRand);
                ArrayTextbox.Text += RandomArray[count].ToString();
                ArrayTextbox.Text += Environment.NewLine;
                count++;
            }
            label1.Content = "An array is created!";
        }

        // Hiermee wordt gecheckt of het ingevoerde nummer wel een nummer is.
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        // Klikt de 'show' button aan en gebruikt de input van een nummer om de corresponderende plaats
        // binnen de array weer te geven.

        private void sort_Click(object sender, RoutedEventArgs e)
        {
            
            label1.Content = "Busy... ";
            if (radioBubble.IsChecked == true)
            {
                int count = 0;
                ArrayTextbox.Text = String.Empty;
                QueryCounter.Start();
                BubbleSort.BubbleSortArrayList<int>(RandomArray);
                QueryCounter.Stop();
                foreach (int value in RandomArray)
                {
                    ArrayTextbox.Text += RandomArray[count].ToString();
                    ArrayTextbox.Text += Environment.NewLine;
                    count++;
                }
                Counter.Content = QueryCounter.Duration(count)/1000000;
                label1.Content = "Done!";
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            Array.Clear(RandomArray, 0, RandomArray.Length);
            ArrayTextbox.Clear();
            int maxRand = RandomArray.Length * 2;
            int min = 0;
            Random randomNo = new Random();
            int count = 0;

            foreach (int value in RandomArray)
            {
                RandomArray[count] = randomNo.Next(min, maxRand);
                ArrayTextbox.Text += RandomArray[count].ToString();
                ArrayTextbox.Text += Environment.NewLine;
                count++;
            }
            label1.Content = "A new array is created!";
        }
    }
}
