using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    // מחלקה ליצירת אויבים
    internal class EnemyFactory
    {
        // רשימה של המופעים אויבים
        public List<Enemy> Enemies { get; set; } = new List<Enemy>();

        // יצירת אויבים
        public void Enemfactory(int sumEnemy)
        {
            for (int i = 0; i < sumEnemy; i++)
            {
                Enemy enemy = new Enemy();
                Console.WriteLine(enemy.Name);
                Enemies.Add(enemy);
            }
        }
    }
}
