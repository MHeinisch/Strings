using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            SystemArrayString run = new SystemArrayString("Hello World");

            string charToString = run.ToString();

            Console.WriteLine(charToString);

            run.Insert(5, "!!!");

            Console.WriteLine(run.ToString());

            run.Remove(11, 3);

            Console.WriteLine(run.ToString());

            Console.WriteLine(run.charArray.Length);

            SystemLinkedListString runLinked = new SystemLinkedListString("Hello World");

            string linkedListToString = runLinked.ToString();

            Console.WriteLine(linkedListToString);

            runLinked.Insert(5, "!!!");

            Console.WriteLine(runLinked.ToString());

            runLinked.Remove(11, 3);

            Console.WriteLine(runLinked.ToString());

            Console.WriteLine(runLinked.charLinkedList.Count());

            CustomLinkedListString runCustom = new CustomLinkedListString("Hello World");

            string customLLToString = runCustom.ToString();

            Console.WriteLine(customLLToString);

            runCustom.Insert(5, "!!!");

            Console.WriteLine(runCustom.ToString());

            runCustom.Remove(11, 3);

            Console.WriteLine(runCustom.ToString());

            Console.WriteLine(runCustom.stringToList.Count());

            SortedList sort = new SortedList();

            foreach(KeyValuePair<int, ICustomString> item in sort.sortedStringList)
            {
                Console.WriteLine(item.Value);
            }

            //for (int i = 0; i < sort.sortedStringList.Count(); i++)
            //{
            //    Console.WriteLine();
            //}

            Console.ReadLine();

        }
    }
}