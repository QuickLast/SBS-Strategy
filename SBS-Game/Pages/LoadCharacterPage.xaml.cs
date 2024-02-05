using SBS_Game.Functions;
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
    /// Логика взаимодействия для LoadCharacterPage.xaml
    /// </summary>
    public partial class LoadCharacterPage : Page
    {
        public LoadCharacterPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CRUD.GetCharacterByName(NameTBk.Text) != null)
            {
                NavigationService.Navigate(new MainPage(CRUD.GetCharacterByName(NameTBk.Text)));
            }
            else
            {
                ErrorTBk.Text = "There's no such character. Please try again.";
            }
        }
    }
}
