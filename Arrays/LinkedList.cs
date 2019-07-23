using System;
using System.Collections.Generic;

namespace DataStructureOverview.Arrays
{
    public class LinkedList
    {
        public void RunExamples()
        {
            var linkedList = new LinkedList<string>();

            Console.WriteLine("Inserts 'One' and 'Three'.");
            linkedList.AddFirst("One");
            LinkedListNode<string> three = linkedList.AddLast("Three");
            PrintLinkedListElements(linkedList);

            Console.WriteLine("Inserts 'Two' before 'Three'.");
            linkedList.AddBefore(three, "Two");
            PrintLinkedListElements(linkedList);

            Console.WriteLine("Inserts 'Four' after 'Three'.");
            linkedList.AddAfter(three, "Four");
            PrintLinkedListElements(linkedList);
        }

        private void PrintLinkedListElements<T>(LinkedList<T> list)
        {
            foreach(T element in list)
            {
                Console.WriteLine(element);
            }
        }
        
    }
}
