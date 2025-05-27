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
            Seacommandor seaCommando = new Seacommandor("David", "d456", Status.Standing);
            AirCommando airCommando = new AirCommando("Eli", "e789", Status.Standing);
            
            Commando[] Array1 = new Commando[] { noam, seaCommando, airCommando };
            foreach (Commando commando in Array1)
            {
                commando.Attack();
            }

            Weapon weapon = new Weapon("AK-47", "Kalashnikov", 30);
            


        }
    }
}
