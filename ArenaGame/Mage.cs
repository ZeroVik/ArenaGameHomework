using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mage : Hero
    {
        private const int ParadoxChance = 20;
        private const int ShieldChance = 15;


        public Mage(string name) : base(name)
        {
            Strength = 120;
            Health = 400;
            StartingHealth = Health;
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(ParadoxChance))
            {
                Console.WriteLine($"{Name} casts Paradox!");
                attack += 30;
            }
            return attack;
        }
        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(ShieldChance))
            {
                incomingDamage = 0;
                Console.WriteLine($"{Name} activates a magical shield and blocks all damage!");
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
