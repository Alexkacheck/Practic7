using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    class MyClass
    {
        public int Value { get; set; }

        public MyClass(int value)
        {
            Value = value;
        }

        public static bool operator ==(MyClass obj1, MyClass obj2)
        {
            return obj1.Value == obj2.Value;
        }

        public static bool operator !=(MyClass obj1, MyClass obj2)
        {
            return obj1.Value != obj2.Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is MyClass other)
            {
                return this.Value == other.Value;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass obj1 = new MyClass(5);
            MyClass obj2 = new MyClass(10);

            if (obj1 == obj2)
            {
                Console.WriteLine("Объекты равны.");
            }
            else
            {
                Console.WriteLine("Объекты не равны.");
            }
        }
    }
}
