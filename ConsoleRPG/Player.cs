using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    class Player
    {
        private string _name;
        private float _health;
        private float _defense;
        private float _power;
        private Item _currentItem;

        public Player(string name, float health, float defense, float power)
        {
            _name = name;
            _health = health;
            _defense = defense;
            _power = power;
        }
        
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
