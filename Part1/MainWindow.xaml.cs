/// Lab No. 3		Exercise Part 1
/// File Name: PigLatinGUI
/// @author: Evan Sinclair
/// Date:  Sept 18, 2020
///
/// Problem Statement: Use a GUI to change a name into Pig Latin and capitalize it
/// 
/// 
/// Overall Plan:
/// 1)Create text fields for input
/// 2)Create Button for execution
/// 3)create pigliatin names using char.ToUpper() on the second character in the name + substring third position + first letter + "ay"
/// 4)Output pig latin names
///
///

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

namespace Part1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String pigLatinFirstName;
            String pigLatinLastName;
            String firstName = fntxtbox.Text;
            String lastName = lntxtbox.Text;
            pigLatinFirstName = char.ToUpper(firstName[1]) + firstName.Substring(2) + char.ToLower(firstName[0]) + "ay";
            pigLatinLastName = char.ToUpper(lastName[1]) + lastName.Substring(2) + char.ToLower(lastName[0]) + "ay";

            MessageBox.Show("Your name in piglatin is: " + pigLatinFirstName + " " + pigLatinLastName);
        }
    }
}
