using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class SortHelper
    {
        ShopStorage ShopInventory = new ShopStorage();


        public IEnumerable<Item> SortBy(List<SortType> sortType)
        {

            var query = ShopInventory.OrderBy(e => e.ID);

            for (int i = sortType.Count - 1; i >= 0; i--)
            {
                switch (sortType[i])
                {
                    case SortType.ID:
                        query = query.OrderBy(e => e.ID);
                        break;
                    case SortType.Name:
                        query = query.OrderBy(e => e.Name);
                        break;
                    case SortType.Price:
                        query = query.OrderBy(e => e.Price);
                        break;
                    case SortType.Cat:
                        query = query.OrderBy(e => e.Cat);
                        break;
                }
            }

            return query;
        }



    }
}
