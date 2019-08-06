using System;
using System.Collections.Generic;

namespace DataStructureOverview.Lists
{
    public class SortedListExamples
    {
        public void Run()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(3, "Marcos");
            sortedList.Add(2, "Julia");
            sortedList.Add(1, "Pedro");
            PrintKeysAndValues( sortedList );

            sortedList[1] = "Maria";
            sortedList[4] = "Joao";
            PrintKeysAndValues( sortedList );

            try
            {
                sortedList.Add( 1, "Fernando");
            }
            catch 
            {
                Console.WriteLine("A pair with Key = 1 already exists.");
            }
        }
        
        public static void PrintKeysAndValues(SortedList<int, string> sortedList )  
        {
            Console.WriteLine( "SortedList:" );
            foreach( KeyValuePair<int, string> pair in sortedList )
            {
                Console.WriteLine( "Key: {0}, Value: {1}", 
                pair.Key, pair.Value);
            }
        } 
    }
}