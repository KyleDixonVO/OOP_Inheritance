using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    class GameCharacter
    {
        public int health;

        public void TakeDamage(int damage)
        {
            health -= damage;
        }
    }
}
