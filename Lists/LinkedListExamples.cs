using System;
using System.Collections.Generic;

namespace DataStructureOverview.Lists
{
    public class LinkedListExamples
    {
        public void Run()
        {
            var linkedList = new LinkedList<string>();
            var nodeOne = new LinkedListNode<string>("One");
            var nodeTwo = new LinkedListNode<string>("Two");
            var nodeThree = new LinkedListNode<string>("Three");

            linkedList.AddLast(nodeOne);
            linkedList.AddLast(nodeTwo);
            linkedList.AddLast(nodeThree);
            PrintElements(linkedList);

            linkedList.AddAfter(linkedList.Find("Two"),"TwoAndAHalf");
            PrintElements(linkedList);
            PrintElementsUsingPrevious(linkedList.Last);
        }

        private void PrintElements<T>(LinkedList<T> list)
        {
            Console.WriteLine("Linked list elements:");

            foreach(T element in list)
            {
                Console.WriteLine(element);
            }
        }

        private void PrintElementsUsingPrevious(LinkedListNode<string> linkedlistNode)
        {
            Console.WriteLine("Linked list elements (reverse):");
            var node = linkedlistNode;

            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Previous;
            }
        }
    }
}
