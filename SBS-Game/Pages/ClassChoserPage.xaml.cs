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

namespace SBS_Game.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClassChoserPage.xaml
    /// </summary>
    public partial class ClassChoserPage : Page
    {
        public ClassChoserPage()
        {
            InitializeComponent();
        }

        private void Warrior_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ErrorTBk.Text = string.Empty;
            if (ErrorTBk.Text == String.Empty && NameTBk.Text != String.Empty)
                NavigationService.Navigate(new MainPage("Warrior", NameTBk.Text.Trim()));
            else
                ErrorTBk.Text = "Please enter a name of a character";
        }

        private void Wizard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ErrorTBk.Text = string.Empty;
            if (ErrorTBk.Text == String.Empty && NameTBk.Text != String.Empty)
                NavigationService.Navigate(new MainPage("Wizard", NameTBk.Text.Trim()));
            else
                ErrorTBk.Text = "Please enter a name of a character";
        }

        private void Rogue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ErrorTBk.Text = string.Empty;
            if (ErrorTBk.Text == String.Empty && NameTBk.Text != String.Empty)
                NavigationService.Navigate(new MainPage("Rogue", NameTBk.Text.Trim()));
            else
                ErrorTBk.Text = "Please enter a name of a character";
        }
    }
}
