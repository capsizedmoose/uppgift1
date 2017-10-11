using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
