using CROC.PRG.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROC.PRG.Character
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int HealthPoint { get; set; }
        public int ManaPoint { get; set; }
        public int DamagePerHit { get; set; }
        public int Armor { get; set; }
        public Weapon Weapon { get; set; }


    }
}
