using System;
using System.Collections.Generic;

namespace DataStructureOverview.Lists
{
    public class SortedListExamples
    {
        public void Run()
        {
            var sortedList = new SortedList<string, string>();
            sortedList.Add("3", "Marcos");
            sortedList.Add("2", "Julia");
            sortedList.Add("1", "Pedro");
            PrintKeysAndValues( sortedList );

            sortedList["1"] = "Maria";
            sortedList["4"] = "Joao";
            PrintKeysAndValues( sortedList );

            var isAdded = sortedList.TryAdd("1","Fernando");

            try
            {
                sortedList.Add( "1", "Fernando");
            }
            catch(Exception exception)
            {
                // Console.WriteLine("A pair with Key = 1 already exists.");
                Console.WriteLine(exception.Message);
            }
        }
        
        public static void PrintKeysAndValues(SortedList<string, string> sortedList )  
        {
            Console.WriteLine( "SortedList:" );
            foreach( KeyValuePair<string, string> pair in sortedList )
            {
                Console.WriteLine( "Key: {0}, Value: {1}", 
                pair.Key, pair.Value);
            }
        } 
    }
}