using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Comandos
{
    internal class log
    {
        public void Log() 
        { 
            string wert = "./log88.txt";
            string rer = "asher tyyuu" + System.DateTime.Now;
            File.WriteAllText(wert, rer);
        }

        
    }
}
