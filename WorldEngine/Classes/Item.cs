using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Item
    {
        private int _idNumber;
        private string _name;
        private int _price;
        private string _questItem;
        private string _required;
        private string _description;

        public Item(int idNumber, string name, string description, int price, string questItem, string required)
        {
            IdNumber = idNumber;

            Name = name;

            Description = description;

            Price = price;

            QuestItem = questItem;

            Required = required;

            
        }

        public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int Price { get { return _price; } set { _price = value; } }
        public string QuestItem { get { return _questItem; } set { _questItem = value; } }
        public string Required { get { return _required; } set { _required = value; } }
    }
}