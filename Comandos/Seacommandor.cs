using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos 
{

    //  חיילים ימיים יורש את מחלקת חיילים
    internal class Seacommandor : Commando
    {
        public Seacommandor(string name, string nameCode)
            : base(name, nameCode)
        {

        }

        // מספר מה שהוא עושה
        public void MyStory()
        {
            Console.WriteLine("I am a sea fighter.");
        }

        // פונקציה מהאבא מבצע שינוי גם אצל האבא
        // מוציאה עדכון
        public override void Attack()
        {
            Console.WriteLine($"{NameCode} is attacking from the sea!");
        }
    }
}
