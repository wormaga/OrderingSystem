using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering_System
{
    class Item
    {
        private string name;
        private int id;

        public Item (string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string getItemName()
        {
            return name;
        }

        public int getItemId()
        {
            return id;
        }

    }
}
