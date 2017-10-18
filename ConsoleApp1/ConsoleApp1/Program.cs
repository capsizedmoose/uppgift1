using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static  Uppgift1.HelperClass;



namespace Uppgift1
{
    class Program
    {
        static SortHelper SH = new SortHelper();



        static void Menu() {

            string[] answers = {
                "ID",
                "Name",
                "Price",
                "Category",
                "Price and Name",
                "Price and Category"

            };

            IEnumerable<Item> displayList = new List<Item>();
            while (true) {
                foreach (Item i in displayList)
                {
                    i.PrintItem();
                }
                int nav = MakeMenu("SORT BY:", answers, true);

                

                List<SortType> ST = new List<SortType>();
                switch (nav)
                {
                    case 0:
                        ST.Add(SortType.ID);
                        break;
                    case 1:
                        ST.Add(SortType.Name);
                        break;
                    case 2:
                        ST.Add(SortType.Price);
                        break;
                    case 3:
                        ST.Add(SortType.Cat);
                        break;
                    case 4:
                        ST.Add(SortType.Price);
                        ST.Add(SortType.Name);
                        break;
                    case 5:
                        ST.Add(SortType.Cat);
                        ST.Add(SortType.Price);
                        break;
                }

                displayList = SH.SortBy(ST);

                Console.Clear();
            }

        }



        static void Main(string[] args)
        {
            Menu();
        }
    }

    public enum Category
    {
        Food,
        Drinks,
        Books,
        Movies,
        Clothes
    }
    public enum SortType
    {
        ID,
        Price,
        Name,
        Cat
    }
}
