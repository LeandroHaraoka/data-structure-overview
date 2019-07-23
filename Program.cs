using System;
using System.Text;
using DataStructureOverview.Arrays;

namespace DataStructureOverview
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single Dimensional Arrays
            var singleDimensionalArray = new SingleDimensionalArray();
            singleDimensionalArray.RunExamples();

            // Multiple Dimensional Arrays
            var multipleDimensionalArray = new MultipleDimensionalArray();
            multipleDimensionalArray.RunExamples();

            // ArrayList
            var arrayList = new ArrayList();
            arrayList.RunExamples();

            // sortedList
            // var sortedList = new SortedList();
            // sortedList.RunExamples();

            // ArrayList
            var linkedList = new LinkedList();
            linkedList.RunExamples();
        }
    }
}