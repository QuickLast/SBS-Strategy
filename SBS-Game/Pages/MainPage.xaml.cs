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
        int levellingXP;
        int levelPoints = 0;
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
            currentCharacter.XP += 500;
            XPTBk.Text = (currentCharacter.XP).ToString();
           
            if (currentCharacter.XP == levellingXP + currentCharacter.Level * 1000)
            {
                levellingXP = currentCharacter.XP;
                currentCharacter.Level++;
                levelPoints++;

                LevelTBk.Text = $"Current Level: {currentCharacter.Level.ToString()}";
            }
        }

        private void AddThousandButton_Click(object sender, RoutedEventArgs e)
        {
            currentCharacter.XP += 1000;
            XPTBk.Text = (currentCharacter.XP).ToString();

            if (currentCharacter.XP == levellingXP + currentCharacter.Level * 1000)
            {
                levellingXP = currentCharacter.XP;
                currentCharacter.Level++;
                levelPoints++;

                LevelTBk.Text = $"Current Level: {currentCharacter.Level.ToString()}";
            }
        }

        private void AddStrengthBtn_Click(object sender, RoutedEventArgs e)
        {
            if (currentCharacter.Level > 1 && levelPoints != 0)
            {
                levelPoints -= 1;

                currentCharacter.StrengthP += 1;

                UpdateStats(currentCharacter);
                RefreshStats();
            }
        }

        private void AddDexterityBtn_Click(object sender, RoutedEventArgs e)
        {
            if (currentCharacter.Level > 1 && levelPoints != 0)
            {
                levelPoints -= 1;

                currentCharacter.DexterityP += 1;

                UpdateStats(currentCharacter);
                RefreshStats();
            }
        }

        private void AddIntelligenceBtn_Click(object sender, RoutedEventArgs e)
        {
            if (currentCharacter.Level > 1 && levelPoints != 0)
            {
                levelPoints -= 1;

                currentCharacter.IntelligenceP += 1;

                UpdateStats(currentCharacter);
                RefreshStats();
            }
        }

        private void AddVitalityBtn_Click(object sender, RoutedEventArgs e)
        {
            if (currentCharacter.Level > 1 && levelPoints != 0)
            {
                levelPoints -= 1;

                currentCharacter.VitalityP += 1;

                UpdateStats(currentCharacter);
                RefreshStats();
            }
        }

        public void RefreshStats()
        {
            StrengthTBk.Text = $"Strength: {currentCharacter.StrengthP}/{currentCharacter.MaxStrengthP}";
            DexterityTBk.Text = $"Dexterity: {currentCharacter.DexterityP}/{currentCharacter.MaxDexterityP}";
            IntelligenceTBk.Text = $"Intelligence: {currentCharacter.IntelligenceP}/{currentCharacter.MaxIntelligenceP}";
            VitalityTBk.Text = $"Vitality: {currentCharacter.VitalityP}/{currentCharacter.MaxVitalityP}";

            HealthTBk.Text = $"Health: {currentCharacter.Health}";
            ManaTBk.Text = $"Mana: {currentCharacter.Mana}";

            PDamageTBk.Text = $"Physical Damage: {currentCharacter.PDamage}";
            ArmorTBk.Text = $"Armor {currentCharacter.Armor}";
            MDamageTBk.Text = $"Magical Damage: {currentCharacter.MDamage}";
            MDefenseTBk.Text = $"Magical Defense: {currentCharacter.MDefense}";
            CrtChanseTBk.Text = $"Critical Chanse {currentCharacter.CrtChanse}";
            CrtDamageTBk.Text = $"Critical Damage {currentCharacter.CrtDamage}";

            LevelTBk.Text = $"Current Level: {currentCharacter.Level}";
            XPTBk.Text = $"{currentCharacter.XP}";
        }

        public void UpdateStats(Character character)
        {
            character.CrtChanse = (int)Math.Round(0.2 * character.DexterityP);
            character.CrtDamage = (int)Math.Round(0.1 * character.DexterityP);
            if (character.UnitClass.ToLower() == "warrior")
            {
                character.Health = 2 * character.VitalityP + character.StrengthP;
                character.Mana = character.IntelligenceP;

                character.PDamage = character.StrengthP;
                character.Armor = character.DexterityP;
                character.MDamage = (int)Math.Round(0.2 * character.IntelligenceP);
                character.MDefense = (int)Math.Round(0.5 * character.IntelligenceP);
            }
            else if (character.UnitClass.ToLower() == "rogue")
            {
                character.Health = (int)Math.Round(1.5 * character.VitalityP + 0.5 * character.StrengthP);
                character.Mana = (int)Math.Round(1.2 * character.IntelligenceP);

                character.PDamage = (int)Math.Round(0.5 * character.StrengthP + 0.5 * character.DexterityP);
                character.Armor = (int)Math.Round(1.5 * character.DexterityP);
                character.MDamage = (int)Math.Round(0.2 * character.IntelligenceP);
                character.MDefense = (int)Math.Round(0.5 * character.IntelligenceP);
            }
            else if (character.UnitClass.ToLower() == "wizard")
            {
                character.Health = (int)Math.Round(1.4 * character.VitalityP + 0.2 * character.StrengthP);
                character.Mana = (int)Math.Round(1.5 * character.IntelligenceP);

                character.PDamage = (int)Math.Round(0.5 * character.StrengthP);
                character.Armor = character.DexterityP;
                character.MDamage = character.IntelligenceP;
                character.MDefense = character.IntelligenceP;
            }
            else
            {
                throw new Exception("There's no such class.");
            }
        }
    }
}
