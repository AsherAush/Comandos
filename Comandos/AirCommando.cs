using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{

    //   חיילים אוויריים עם הורשה של מחלקת חיילים 
    internal class AirCommando : Commando

    {
        public AirCommando(string name, string nameCode) 
            : base(name, nameCode)
        {
        }

        // מספר מה הוא עושה
        public void MyStoty()
        {
            Console.WriteLine("I am an air fighter.");
        }

        // פונקציה מהאבא שמבצע שינוי גם אצל האבא
        // מוציאה עדכון
        public override void Attack()
        {
            Console.WriteLine($"{NameCode} is attacking from the air!");
        }
    }
}
