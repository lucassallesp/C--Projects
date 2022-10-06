using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace TicTacToeBRApp
{
    /// <summary>
    /// Interaction logic for PopUp.xaml
    /// </summary>
    public partial class PopUp : Window
    {
        public PopUp()
        {
            InitializeComponent();
        }
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            JogoDaVelha.PlayerSymbol = 'O';
            JogoDaVelha.clearBoard();
            Debug.WriteLine($"{JogoDaVelha.PlayerSymbol} foi escolhido pelo usuario");
            this.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            JogoDaVelha.PlayerSymbol = 'X';
            JogoDaVelha.clearBoard();
            Debug.WriteLine($"{JogoDaVelha.PlayerSymbol} foi escolhido pelo usuario");
            this.Close();
        }
    }
}
