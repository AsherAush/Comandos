using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    // מייצר אויבים
    internal class Enemy
    {
        // פונקצייה רנדומלית
        static Random ran = new Random();
        // ליסט עם שמות 
        List<string> enemyNames = new List<string>
        {
            "Goblin",
            "Orc",
            "Troll",
            "Dragon",
            "Vampire",
            "Zombie",
            "Werewolf",
            "Demon",
            "Giant Spider",
            "Skeleton"
        };
        // שדות - שם, רמת חיים, חי/מת
        public string Name { get; set; }
        public int Life { get; set; } = 100;
        public bool Ifislife = true;

        // אובסטרקטור
        public Enemy()
        {
            this.Name = nameEnemy();
            EnemyShout();

        }

        // פונקציה שבוחרת רנדומלית שם לאויב מהליסט של השמות
        public string nameEnemy()
        {
            return enemyNames[ran.Next(enemyNames.Count)];
        }

        // מדפיסה צעקה
        public void EnemyShout()
        {
            Console.WriteLine($"I {Name} is a enemy:");
        }
        // מדפיס את המופעים
        public override string ToString()
        {
            return $"name is: {Name} level live {Life} if is life {Ifislife} ";
        }

    }
}
