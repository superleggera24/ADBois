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

namespace DLLAD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // hier wordt een array gemaakt.
        private void button_Click(object sender, RoutedEventArgs e)
        {
            RandArray.inputArray();
            label1.Content = "An array is created!";

        }

        // Hiermee wordt gecheckt of het ingevoerde nummer wel een nummer is.
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Klikt de 'show' button aan en gebruikt de input van een nummer om de corresponderende plaats
        // binnen de array weer te geven.
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int no = Convert.ToInt32(textBox.Text);
            label.Content = RandArray.showArray(no);
            textBox.Text = null;
        }

        private void sort_Click(object sender, RoutedEventArgs e)
        {
            if (radioBubble.IsChecked == true)
            {
                RandArray.bubbleArray();
            }
        }
    }
}
