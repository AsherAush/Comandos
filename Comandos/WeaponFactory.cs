using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class WeaponFactory
    {
        // מפעל נשקים שמחזיר את סוג הנשק
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();
    
        public void weaponFactory(string name, string manufacturer, int numOfBalls)
        {
            // מוסיף נשק לרשימה
            Weapons.Add(new Weapon(name, manufacturer, numOfBalls));
        }

    }
}
