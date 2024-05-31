using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    internal class ConjurerWand : Weapon
    {
        public ConjurerWand() : base("Conjurer Wand", 5) { }

        public override void ApplySpecialEffect(Hero attacker, Hero defender)
        {
            if (attacker.ThrowDice(25))
            {
                Console.WriteLine($"{attacker.Name} casts Paradox!");
                defender.TakeDamage(30);
            }
        }
    }
}
