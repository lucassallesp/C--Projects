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

namespace ExperimentWithControls
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

        private void NumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            numberBlock.Text = numberTextBox.Text;
        }

        private void NumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        private void BigSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numberBlock.Text = bigSlider.Value.ToString("000-000-0000");
        }

        private void SmallSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numberTextBox.Text = smallSlider.Value.ToString("0");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                numberBlock.Text = radioButton.Content.ToString();
            }
        }

        private void SelectionBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectionBox.SelectedItem is ListBoxItem listBoxItem)
            {
                numberBlock.Text = listBoxItem.Content.ToString();
            }
        }

        private void MyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (myListBox.SelectedItem is ListBoxItem listBoxItem)
            {
                numberBlock.Text = listBoxItem.Content.ToString();
            }
        }

        private void WriteSelectBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                numberBlock.Text = comboBox.Text;
            }
        }
    }
}