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

namespace ex_0
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

        private void addUserButton_Click(object sender, RoutedEventArgs e)
        {
            string occupation;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            
            if ((bool)studentRadioButton.IsChecked)
                occupation = "student";
            else
                occupation = "teacher";
            CheckBox myCheckBox = new CheckBox();
            if (firstName != "" && lastName != "")
            {
                myCheckBox.Content = $"{firstName} {lastName} ({occupation})";
                usersStackPanel.Children.Add(myCheckBox);
            }
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
        }

        private void removeUserButton_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
