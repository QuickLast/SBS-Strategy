using SBS_Game.Model;
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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        Character currentCharacter;
        public MainPage(Character character)
        {
            InitializeComponent();
            currentCharacter = character;

            NameOfUnitTBk.Text += $" {character.Name}";
            StrengthTBk.Text += $" {character.StrengthP}/{character.MaxStrengthP}";
            DexterityTBk.Text += $" {character.DexterityP}/{character.MaxDexterityP}";
            IntelligenceTBk.Text += $" {character.IntelligenceP}/{character.MaxIntelligenceP}";
            VitalityTBk.Text += $" {character.VitalityP}/{character.MaxVitalityP}";

            HealthTBk.Text += $" {character.Health}";
            ManaTBk.Text += $" {character.Mana}";

            PDamageTBk.Text += $" {character.PDamage}";
            ArmorTBk.Text += $" {character.Armor}";
            MDamageTBk.Text += $" {character.MDamage}";
            MDefenseTBk.Text += $" {character.MDefense}";
            CrtChanseTBk.Text += $" {character.CrtChanse}";
            CrtDamageTBk.Text += $" {character.CrtDamage}";

            LevelTBk.Text += $" {character.Level}";
            XPTBk.Text += $"{character.XP}";

            if (character.UnitClass.ToLower() == "warrior")
            {
                ClassImg.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/Images/warrior1.png"));
            }
            else if (character.UnitClass.ToLower() == "wizard")
            {
                ClassImg.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/Images/wizard1.png"));
            }
            else if (character.UnitClass.ToLower() == "rogue")
            {
                ClassImg.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/Images/rogue1.png"));
            }
        }

        private void AddFiveHundredButton_Click(object sender, RoutedEventArgs e)
        {
            XPTBk.Text = (int.Parse(XPTBk.Text) + 500).ToString();
            currentCharacter.XP += 500;
        }

        private void AddThousandButton_Click(object sender, RoutedEventArgs e)
        {
            XPTBk.Text = (int.Parse(XPTBk.Text) + 1000).ToString();
            currentCharacter.XP += 1000;
        }
    }
}
