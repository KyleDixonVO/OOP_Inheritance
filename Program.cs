using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");
            

            Player player = new Player();
            Enemy enemy = new Enemy();

            player.health = 100;
            Console.WriteLine("Player Health " + player.health);
            player.TakeDamage(10);
            Console.WriteLine("Player Health " + player.health);

            enemy.health = 50;
            Console.WriteLine("Enemy Health " + enemy.health);
            enemy.TakeDamage(10);
            Console.WriteLine("Enemy Health " + enemy.health);

            Console.ReadKey(true);
        }
    }
}
