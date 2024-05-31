using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Masamune : Weapon
    {
        public Masamune() : base("Masamune", 10) { }

        public override void ApplySpecialEffect(Hero attacker, Hero defender)
        {
            if (attacker.ThrowDice(20))
            {
                Console.WriteLine($"{attacker.Name} performs a Light Strike!");
                defender.TakeDamage(20);
            }
        }
    }
}
