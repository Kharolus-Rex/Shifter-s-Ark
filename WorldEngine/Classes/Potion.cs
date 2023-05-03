using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Potion
    {
        private int _idNumber;
        private string _name;
        private string _description;
        private int _price;
        private int _valChange;

        public Potion (int idNumber, string name, string description, int price, int valChange)
        {
            IdNumber = idNumber;

            Name = name;

            Description = description;

            Price = price;

            ValChange = valChange;
        }

        public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int Price { get { return _price; } set { _price = value; } }
        public int ValChange { get { return _valChange; } set { _valChange = value; } }
    }
}
