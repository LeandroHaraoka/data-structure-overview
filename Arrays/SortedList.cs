using System;

namespace DataStructureOverview.Arrays
{
    public class SortedList
    {
        public void RunExamples()
        {
            SortedList mySL = new SortedList();
            mySL.Add("Third", "!");
            mySL.Add("Second", "World");
            mySL.Add("First", "Hello");

            Console.WriteLine( "SortedList:" );
            Console.WriteLine( "  Count:    {0}", mySL.Count );
            Console.WriteLine( "  Capacity: {0}", mySL.Capacity );
            Console.WriteLine( "  Keys and Values:" );
            PrintKeysAndValues( mySL );
        }
        public static void PrintKeysAndValues( SortedList myList )  
        {
            Console.WriteLine( "\t-KEY-\t-VALUE-" );
            for ( int i = 0; i < myList.Count; i++ )  {
                Console.WriteLine( "\t{0}:\t{1}", myList.GetKey(i), myList.GetByIndex(i) );
            }
            Console.WriteLine();
        } 
    }
}