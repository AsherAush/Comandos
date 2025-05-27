using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class AirCommando : Commando

    {
        public AirCommando(string name, string nameCode, Status status) 
            : base(name, nameCode, status)
        {
        }
        public void MyStoty()
        {
            Console.WriteLine("I am an air fighter.");
        }

        public override void Attack()
        {
            Console.WriteLine($"{NameCode} is attacking from the air!");
        }
    }
}
