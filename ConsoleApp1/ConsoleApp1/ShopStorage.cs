using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class ShopStorage : ItemStorage<Item>
    {
        int sortIndex = 0;
        public ShopStorage()
        {
            Add(new Item { ID=1, Cat = Category.Food, Name = "Morot", Price = 2.50});
            Add(new Item { ID = 2, Cat = Category.Food, Name = "Banan", Price = 1.00 });
            Add(new Item { ID = 3, Cat = Category.Drinks, Name = "Kaffe", Price = 45.00 });
            Add(new Item { ID = 4, Cat = Category.Clothes, Name = "Jeans", Price = 299.00 });
            Add(new Item { ID = 5, Cat = Category.Drinks, Name = "CocaCola", Price = 12.50 });
            Add(new Item { ID = 6, Cat = Category.Movies, Name = "Star Wars", Price = 199.90 });
            Add(new Item { ID = 7, Cat = Category.Books, Name = "I Samlarens Spår", Price = 149.90 });
            Add(new Item { ID = 8, Cat = Category.Clothes, Name = "T-shirt", Price = 2.50 });
            Add(new Item { ID = 9, Cat = Category.Food, Name = "Lyxig Gurka", Price = 10.00 });
            Add(new Item { ID = 10, Cat = Category.Movies, Name = "Pirates of the Caribbean", Price = 99.90 });
        }

        

    }
}
