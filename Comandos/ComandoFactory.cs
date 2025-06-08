using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class ComandoFactory
    {
        // רשימה של המופעים חיילים
        public List<Commando> Comandos { get; set; } = new List<Commando>();
        // יצירת פקודות
        public void comandoFactory(string name, string nameCode, string typecomando)
        {
            switch (typecomando)
            {
                case "Air":
                    Comandos.Add(new AirCommando(name, nameCode));
                    break;
                case "Sea":
                    Comandos.Add(new Seacommandor(name, nameCode));
                    break;
                case "orginal":
                    Comandos.Add(new Commando(name, nameCode));
                    break;
            }
        }

    }
}
