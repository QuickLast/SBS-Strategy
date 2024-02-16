using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS_Game.Model
{
    public class Dagger
    {
        public bool isTwoHanded = false;
        public bool canBeUsedWithShield = true;
        public bool canBeDual = true;
        public string rarity = "common";

        public int pDamageRatio = 4;
        public int manaRatio = 20;
        public int intelligenceRatio = 20;

        public static int crtChanse = 0;
        public static int crtDamage = 0;
        public int magicCrit = Convert.ToInt32(crtChanse * 0.05 + crtDamage * 3);
    }
}
