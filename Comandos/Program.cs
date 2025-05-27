using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando noam = new Commando("asher", "a125", Status.Standing);
            Console.WriteLine(noam);
            noam.Walk();
            Console.WriteLine(noam);
            noam.Hide();
            Console.WriteLine(noam);
            noam.Attack();

            Weapon weapon = new Weapon("AK-47", "Kalashnikov", 30);
            Console.WriteLine(weapon);
            weapon.Shoot();
            Console.WriteLine(weapon);


        }
    }
}
