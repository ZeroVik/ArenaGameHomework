using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class PerseusBow : Weapon
    {
        public PerseusBow() : base("PerseusBow", 8) { }

        public override void ApplySpecialEffect(Hero attacker, Hero defender)
        {
            if (attacker.ThrowDice(15))
            {
                Console.WriteLine($"{attacker.Name} shoots a Dark Arrow!");
                defender.TakeDamage(15);
            }
        }
    }
}
