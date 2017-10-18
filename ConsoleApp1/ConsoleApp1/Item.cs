using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Uppgift1.HelperClass;

namespace Uppgift1
{
    public class Item : IEquatable<Item>,IComparable<Item>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Cat { get; set; }

        public bool Equals(Item other) {
            if (other == null)
                return false;
            if (this.ID == other.ID)
                return true;
            else
                return false;
        }
        public int CompareTo(Item other) {
            return ID.CompareTo(other.ID);
        }

        public void PrintItem()
        {

            CngCol(ConsoleColor.White);
            Console.Write(" ID:");
            CngCol(ConsoleColor.Red);
            Console.Write(ID);



            Console.SetCursorPosition(8, Console.CursorTop);
            CngCol(ConsoleColor.White);
            Console.Write("Cat:");
            CngCol(ConsoleColor.Cyan);
            Console.Write(Cat);



            Console.SetCursorPosition(24, Console.CursorTop);
            CngCol(ConsoleColor.White);
            Console.Write("Name:");
            CngCol(ConsoleColor.Magenta);
            Console.Write(Name);



            Console.SetCursorPosition(Console.WindowWidth-20, Console.CursorTop);
            CngCol(ConsoleColor.White);
            Console.Write("Price:");
            CngCol(ConsoleColor.Green);
            Console.WriteLine(Price);
            CngCol(ConsoleColor.Gray);
        }


    }
}
