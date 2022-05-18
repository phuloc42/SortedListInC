using SortedListInC;
using System;
using System.Collections;

namespace SortedListInC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedList mySL = new SortedList(new PersonComparer());
            mySL.Add(new Person("Loc", 29), 10);
            mySL.Add(new Person("Thanh", 22), 15);

            foreach(DictionaryEntry item in mySL)
            {
                Console.WriteLine("key:" + item.Key + "\tValue:" + item.Value);
            }
            Console.WriteLine();
           
        }
    }
}
class PersonComparer : IComparer
{
    public int Compare(object x, object y)
    {
        Person a = x as Person;
        Person b = y as Person;

        if (a == null || b == null)
        {
            throw new InvalidOperationException();
        }
        else
        {
            if (a.Age > b.Age)
            {
                return 1;
            }
            else if (a.Age == b.Age)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}