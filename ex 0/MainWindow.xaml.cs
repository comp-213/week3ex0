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
        int numberOfUsers = 0;
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
            numberOfUsers++;
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
        }

        private void removeUserButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= numberOfUsers; i++)//loop is needed to check every single checkbox and not stop on the first one,
            {                                        //oteherwise the foreach loop stops because the size was changed
                foreach (var element in usersStackPanel.Children)
                {
                    if (element is CheckBox)
                    {
                        var cb = element as CheckBox;
                        if ((bool)cb.IsChecked)
                        {
                            usersStackPanel.Children.Remove(cb);
                            break;
                        }
                    }
                }
            }
        }
    }
}
