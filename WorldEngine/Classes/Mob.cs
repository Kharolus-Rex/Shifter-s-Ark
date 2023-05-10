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
        private string _description;
        private string _race;
        private string _class;
        private int _HP;
        private int _AC;
        private int _weaponID;

        public Mob(int idNumber, string name, string description, string race, string Class, int hp, int ac, int weaponID)
        {
            IdNumber = idNumber;
            Name = name;
            Description = description;
            Race = race;
            CLass = Class;
            HP = hp;
            AC = ac;
            WeaponID = weaponID;
        }

        public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Race { get { return _race; } set { _race = value; } }
        public string CLass { get { return _class; } set { _class = value; } }
        public int HP { get { return _HP; } set { _HP = value; } }
        public int AC { get { return _AC; } set { _AC = value; } }
        public int WeaponID { get { return _weaponID; } set { _weaponID = value; } }
    }
}