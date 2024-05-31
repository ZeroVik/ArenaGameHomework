using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Bard : Hero
    {
        private const int HealChance = 15;
        private const int SongBuffChance = 10;

        public Bard(string name) : base(name)
        {
            Strength = 90;
            Health = 450;
            StartingHealth = Health;
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(SongBuffChance))
            {
                Console.WriteLine($"{Name} sings a powerful song!");
                attack *= 2;
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            base.TakeDamage(incomingDamage);
            if (ThrowDice(HealChance))
            {
                int healAmount = StartingHealth * 20 / 100;
                Heal(healAmount);
                Console.WriteLine($"{Name} heals for {healAmount} health!");
            }
        }
    }
}
