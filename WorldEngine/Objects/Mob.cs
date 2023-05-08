using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Mob
    {
        private int _idNumber;
        private string _name;
        private string _race;
        private string _class;
        private int _HP;
        private int _AC;
        private Weapon _weapon; //this should work. TODO - Eventually test if this works.

        public Mob(int idNumber, string name, string race, string Class, int hp, int ac, Weapon weapon)
        {
            IdNumber = idNumber;
            Name = name;
            Race = race;
            CLass = Class;
            HP = hp;
            AC = ac;
            WEapon = weapon;
        }

        public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Race { get { return _race; } set { _race = value; } }
        public string CLass { get { return _class; } set { _class = value; } }
        public int HP { get { return _HP; } set { _HP = value; } }
        public int AC { get { return _AC; } set { _AC = value; } }
        public Weapon WEapon { get { return _weapon; } set { _weapon = value; } }
    }
}
