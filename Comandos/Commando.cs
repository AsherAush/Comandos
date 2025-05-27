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

        private string Name ;
        //public string GetName()
        //{
        //    return Nam e;
        //}   
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
        public virtual void Attack()
        {
            Console.WriteLine( $"{NameCode} is attacking!");
        }

        public void SayName(string commanderRank)
        {
            if (commanderRank == "General")
            {
                Console.WriteLine(Name);
            }
            else if (commanderRank == "Colonel")
            {
                Console.WriteLine(NameCode);
            }
            else
            {
                Console.WriteLine("Unknown rank");
            }
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
