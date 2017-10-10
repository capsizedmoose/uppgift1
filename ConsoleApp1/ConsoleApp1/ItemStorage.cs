using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class ItemStorage
    {

        public ItemStorage()
        {
            itemList = new List<Item>() {

            new Item { ID=1, Cat = Category.Food, Name = "Morot", Price = 2.50},


            }
        }
    }
}
