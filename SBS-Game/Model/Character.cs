using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS_Game.Model
{
    public class Character
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string UnitClass { get; set; }
        public int StrengthP { get; set; }
        public int MaxStrengthP { get; set; }
        public int DexterityP { get; set; }
        public int MaxDexterityP { get; set; }
        public int IntelligenceP { get; set; }
        public int MaxIntelligenceP { get; set; }
        public int VitalityP { get; set; }
        public int MaxVitalityP { get; set; }
        public int Level { get; set; }
        public int XP { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int PDamage { get; set; }
        public int Armor { get; set; }
        public int MDamage { get; set; }
        public int MDefense { get; set; }   
        public int CrtChanse { get; set; }
        public int CrtDamage { get; set; }

        public Character(string name, string unitClass)
        {
            Name = name;
            UnitClass = unitClass;
            CrtChanse = (int)Math.Round(0.2 * DexterityP);
            CrtDamage = (int)Math.Round(0.1 * DexterityP);
            if (unitClass.ToLower() == "warrior")
            {
                StrengthP = 30;
                MaxStrengthP = 250;
                DexterityP = 15;
                MaxDexterityP = 80;
                IntelligenceP = 10;
                MaxIntelligenceP = 50;
                VitalityP = 25;
                MaxVitalityP = 100;
                Level = 0;
                XP = 0;
                Health = 2 * VitalityP + StrengthP;
                Mana = IntelligenceP;

                PDamage = StrengthP;
                Armor = DexterityP;
                MDamage = (int)Math.Round(0.2 * IntelligenceP);
                MDefense = (int)Math.Round(0.5 * IntelligenceP);
            }
            else if (unitClass.ToLower() == "rogue")
            {
                StrengthP = 20;
                MaxStrengthP = 65;
                DexterityP = 30;
                MaxDexterityP = 250;
                IntelligenceP = 15;
                MaxIntelligenceP = 70;
                VitalityP = 20;
                MaxVitalityP = 80;
                Level = 0;
                XP = 0;
                Health = (int)Math.Round(1.5 * VitalityP + 0.5 * StrengthP);
                Mana = (int)Math.Round(1.2 * IntelligenceP);

                PDamage = (int)Math.Round(0.5 * StrengthP + 0.5 * DexterityP);
                Armor = (int)Math.Round(1.5 * DexterityP);
                MDamage = (int)Math.Round(0.2 * IntelligenceP);
                MDefense = (int)Math.Round(0.5 * IntelligenceP);
            }
            else if (unitClass.ToLower() == "wizard")
            {
                StrengthP = 15;
                MaxStrengthP = 45;
                DexterityP = 20;
                MaxDexterityP = 80;
                IntelligenceP = 35;
                MaxIntelligenceP = 250;
                VitalityP = 15;
                MaxVitalityP = 70;
                Level = 0;
                XP = 0;
                Health = (int)Math.Round(1.4 * VitalityP + 0.2 * StrengthP);
                Mana = (int)Math.Round(1.5 * IntelligenceP);

                PDamage = (int)Math.Round(0.5 * StrengthP);
                Armor = DexterityP;
                MDamage = IntelligenceP;
                MDefense = IntelligenceP;
            }
            else
            {
                throw new Exception("There's no such class.");
            }
        }
    }
}
