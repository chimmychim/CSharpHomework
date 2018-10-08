using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace program2
{
    public class DictionaryTest
    {
        public static void Main()
        {
            Person p1 = new Person("Customer1 ", "Trade1", 1, 120, 10);
            Person p2 = new Person("Customer2 ", "Trade2", 2, 240, 4);
            Person p3 = new Person("Customer3 ", "Trade3", 3, 340, 23);
            Person p4 = new Person("Customer4 ", "Trade4", 4, 560, 8);
            Person[] Persons = { p1, p2, p3,p4 };

            Person p5 = new Person("Customer2 ", "Trade2", 2, 240, 4);
            p5 = p2;
            int i = Array.BinarySearch<Person>(Persons, p5);
            Console.WriteLine(p5);



            Random rnd = new Random();
            SortedList list1 = new SortedList();
            foreach (Person r in Persons)
                list1.Add(r, "Room:" + rnd.Next(1000));
            PrintKeysAndValues(list1);

            SortedList list2 =
                new SortedList(list1, new MyComparer());
            PrintKeysAndValues(list2);

        }

        public struct Person : IComparable
        {
            public string CustomerName;
            public string TradeName;
            public int Num;
            public int Price;
            public int Amount;
            public Person(string customerName, string tradeName, int num, int price, int amount)
            {
                this.CustomerName = customerName;
                this.TradeName = tradeName;
                this.Num = num;
                this.Price = price;
                this.Amount = amount;
            }
            public int CompareTo(object obj2)
            {
                if (!(obj2 is Person))
                    throw new System.ArgumentException();
                Person rec2 = (Person)obj2;
                if (this.Num > rec2.Num) return 1;
                else if (this.Num == rec2.Num) return 0;
                return -1;
            }
            public override string ToString()
            {
                return "CustomerName:" + CustomerName + "\tTradeName:" + TradeName + "\tNum:" + Num + "\tPrice:" + Price + "\tAmount:" + Amount;
            }
        }

        public class MyComparer : IComparer
        {
            public int Compare(object obj1, object obj2)
            {
                if (!(obj2 is Person) || !(obj2 is Person))
                    throw new System.ArgumentException();
                Person rec1 = (Person)obj1;
                Person rec2 = (Person)obj2;
                return rec1.CustomerName.ToLower().CompareTo(rec2.CustomerName.ToLower());
            }
        }

        public static void PrintKeysAndValues(SortedList myList)
        {
            IDictionaryEnumerator myEunmerator = myList.GetEnumerator();
            while (myEunmerator.MoveNext())
                Console.WriteLine("\t{0}:\t\t{1}",
            myEunmerator.Key, myEunmerator.Value);
            Console.WriteLine();
        }
    }
}

