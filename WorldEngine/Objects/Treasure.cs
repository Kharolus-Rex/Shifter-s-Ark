using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Treasure
    {
        private int _idNumber;
        private string _name;
        private string _description;
        private int _price;
        private string _questItem; //just a 'yes' or 'no' value

        public Treasure (int idNumber, string name, string description, int price, string questItem)
        {
            IdNumber = idNumber;

            Name = name;

            Description = description;

            Price = price;

            QuestItem = questItem;
        }

        public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int Price { get { return _price; } set { _price = value; } }
        public string QuestItem { get { return _questItem; } set { _questItem = value; } }
    }
}
