using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    enum Tools
{
    Hammer,
    Chisel,
    Rope,
    Bag,
    WaterBottle
}
    enum Status
    {
        Standing,
        Walking,
        Hiding,
    }
    internal class Commando
    {
        public string Name { get; set; }
        public string NameCode { get; set; }
        public List<Tools> Tolls { get; set; } = new List<Tools> 
        {Tools.Hammer, Tools.Chisel, Tools.Rope, Tools.Bag, Tools.WaterBottle};
    
        public Status StatusComando { get; set; } 


        public  Commando(string name, string nameCode, Status status)
        {
            Name = name;
            NameCode = nameCode;
            //Tolls = tolls;
            StatusComando = status;

        }

        public void Walk()
        {
            StatusComando = Status.Walking;
            Console.WriteLine($"{Name} is now walking.");
        }

        public void Hide()
        {
            StatusComando = Status.Hiding;
            Console.WriteLine($"{Name} is now hiding.");
        }
        public void Attack()
        {
            Console.WriteLine( $"{NameCode} is attacking!");
        }

        public override string ToString()
        {
            string toolsList = string.Join(", ", Tolls);
            return $"Commando Name: {Name}\n" +
                   $"Code Name: {NameCode}\n" +
                   $"Status: {StatusComando}\n" +
                   $"Tools: {toolsList}";
        }




    }



}
