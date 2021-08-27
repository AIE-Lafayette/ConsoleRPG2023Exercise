using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    class Goblin
    {
        private float _health;
        private float _damage;
        private float _defense;
        private float _power;
        private float _name;

        public float TakeDamage(float damage)
        {
            float damageTaken = damage - _defense;

            if (damageTaken < 0)
            {
                damageTaken = 0;
            }

            _health -= damageTaken;
            return damageTaken;
        }


    }
}
