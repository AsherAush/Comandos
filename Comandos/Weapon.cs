using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    // מחלקה של נשקים
    internal class Weapon
    {
        // שדות - שם, יצרן, מספר כדורים 
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int NumOfBalls { get; set; }


        // בנאי 
        public Weapon(string name, string manufacturer, int numOfBalls)
        {
            Name = name;
            Manufacturer = manufacturer;
            NumOfBalls = numOfBalls;
        }

        // מוציאה הודעת תקיפה
        public void Shoot()
        {
            if (NumOfBalls <= 0)
            {
                Console.WriteLine("No more balls to shoot!");
            }
            else
            {
                NumOfBalls -= 1;
                Console.WriteLine("Boom");
            }
        }

        // מדפיסה את המופע
        public override string ToString()
        {
            return $"Weapon: {Name}, Manufacturer: {Manufacturer}, Balls left: {NumOfBalls}";
        }
    }
}
