using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos 
{
    internal class Seacommandor : Commando
    {
        public Seacommandor(string name, string nameCode, Status status)
            : base(name, nameCode, status)
        {

        }

        public void MyStory()
        {
            Console.WriteLine("I am a sea fighter.");
        }
        public override void Attack()
        {
            Console.WriteLine($"{NameCode} is attacking from the sea!");
        }
    }
}
