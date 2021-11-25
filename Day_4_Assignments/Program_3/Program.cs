using System;
using System.Collections.Generic;

namespace FourthDay_Assignment4_Program3_CollectionTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //  01. System.Collections.Generic
            /*              GenericUriParser colletion Type -
                            1.list
                            2.LikedList
                            3.SortedList
                            4.Stack
                            5.Queue
                            6.HashSet
                            7.SortedSet
                            8.Dictionary
                            9.SortedDictionary


           02.  System.Collections classes
            These classes are legacy.
            It is suggested now to use System.Collections.Generic classes.
            The System.Collections namespace has following classes:

           1. ArrayList
           2. Stack
           3. Queue
           4. Hashtable

            */


            //list --->
            // Create a list of strings- Generic.
            List<string> listVar = new List<string>();
        
            //    var listVar = new List<string>() {"one","two","three","four" };
            
            listVar.Add("one");
            listVar.Add("two");
            listVar.Add("three");
            listVar.Add("four");

            Console.WriteLine("List --> ");
            // Iterate through the list.
            foreach (string l in listVar)
            {
                Console.Write(l + " ");
            }
            // Output: one two three four
            Console.WriteLine("\n-------------");


            //LinkedList ---

            string[] words ={ "the", "world", "is", "changing", "..." };
            LinkedList<string> linkVar = new LinkedList<string>(words);
            Console.WriteLine(" Linked List --> ");
            foreach (string s in linkVar)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine("\n-------------");


            //sorted list
            SortedList<int, string> sortVar =
            new SortedList<int, string>();

            sortVar.Add(1,"r");
            sortVar.Add(101, "ee");
            sortVar.Add(14, "taet");
            sortVar.Add(51, "bt");
            sortVar.Add(156, "bgh");
            sortVar.Add(10, "dfs");


            Console.WriteLine(" sorted List --> ");
            foreach (KeyValuePair<int,string> kvp in sortVar)
            {
                Console.Write(kvp.Key + " "+kvp.Value+ "\n");
            }

            Console.WriteLine("\n-------------");


            Console.ReadKey();
        }
    }
}
