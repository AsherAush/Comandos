using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{

    // מגדיר את סוגי הכלים
    enum Tools
{
    Hammer,
    Chisel,
    Rope,
    Bag,
    WaterBottle
}
    // מגדיר את סוגי הסטטוס
    enum Status
    {
        Standing,
        Walking,
        Hiding,
    }
    internal class Commando
    {
        // שדות - שם, שם קוד, ליסט כלים, סטטוס הולך/עומד/מתחבא, 
        private string Name ;
        
        public string NameCode { get; set; }
        // מאתחל את הכלים
        public List<Tools> Tolls { get; set; } = new List<Tools> 
        {Tools.Hammer, Tools.Chisel, Tools.Rope, Tools.Bag, Tools.WaterBottle};
    
        public Status StatusComando { get; set; } 

        // בנאי 
        public  Commando(string name, string nameCode)
        {
            Name = name;
            NameCode = nameCode;
            StatusComando = Status.Standing;

        }

        // משנה את הסטטוס להולך 
        public void Walk()
        {
            StatusComando = Status.Walking;
            Console.WriteLine($"{Name} is now walking.");
        }
        // משנה את הסטטוס  למתחבא
        public void Hide()
        {
            StatusComando = Status.Hiding;
            Console.WriteLine($"{Name} is now hiding.");
        }
        // מוציאה הודעה של תקיפה
        public virtual void Attack()
        {
            Console.WriteLine( $"{NameCode} is attacking!");
        }
        // מגבילה את גילוי שם החייל
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
        // מדפיסה את המופע
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
