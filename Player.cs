using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OOP_Inheritance
{
    class Player : GameCharacter
    {
        public int lives;
        public int score;

        public void UnitTest()
        {
            // 1) typical cases
            //  -normal
            health = 100;
            TakeDamage(10);
            Debug.Assert(health == 90);
            //  -range checking
            health = 100;
            TakeDamage(125);
            Debug.Assert(health == 0);
        }
    }


}
