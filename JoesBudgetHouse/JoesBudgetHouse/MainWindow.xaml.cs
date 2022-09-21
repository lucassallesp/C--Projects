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

namespace JoesBudgetHouse
{
    /// <summary>
    /// This program generates a random item menu for a restaurant 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();  // Initialize all the components    
            MakeTheMenu();          // Initialize a method to create the restaurant menu
        }

        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];     // Create a five position vector of MenuItem class
            
            for (int i = 0; i < 5; i++)
            {
                // We instanciate an object of MenuItem class in each vector position
                menuItems[i] = new MenuItem();

                if (i >= 3) // Create four new kinds of bread to randomize from position three
                {
                    menuItems[i].Breads = new string[]
                    {
                       "Plain Bagel", "Onion Bagel", "Pumpernickel Bagel", "Everything Bagel"
                    };
                }
                menuItems[i].Generate();    // Uses the Generate() method to randomize the restaurant menu
            }

            // Sets all TextBlocks with its repective changed results in the class fields of menuItems

            item1.Text = menuItems[0].Description;
            price1.Text = menuItems[0].Price;

            item2.Text = menuItems[1].Description;
            price2.Text = menuItems[1].Price;

            item3.Text = menuItems[2].Description;
            price3.Text = menuItems[2].Price;

            item4.Text = menuItems[3].Description;
            price4.Text = menuItems[3].Price;

            item5.Text = menuItems[4].Description;
            price5.Text = menuItems[4].Price;

            // Instaciate a new object to make reference to a special menu that will have special ingredients
            MenuItem specialMenuItem = new MenuItem()
            {
                Proteins = new string[] { "Organic Ham", "Mushroom Patty", "Mortadella"},
                Condiments = new string[] { "Dijon Mustard", "Miso Dresseing", "Au Jus"},
                Breads = new string[] { "A Gluten Free Roll", "A Wrap", "Pitta" },
            };
            specialMenuItem.Generate(); // Generates again a randomized set of items in specialMenuItem object

            // Set the TextBlock with its respective changed result
            item6.Text = specialMenuItem.Description;
            price6.Text = specialMenuItem.Price;

            // Instaciate a new object for a fixed dessert
            MenuItem guacamoleMenuItem = new MenuItem();
            guacamoleMenuItem.Generate();

            guacamole.Text = "Add Guacamole for " + guacamoleMenuItem.Price;
        }           
    }  
}

        
