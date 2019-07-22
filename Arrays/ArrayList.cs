using System;

namespace DataStructureOverview.Arrays
{
    public class ArrayList
    { 
        public void RunExamples()
        {
            var arrayList = new System.Collections.ArrayList();
            arrayList.Add(1);
            arrayList.AddRange(new int[] {2, 3, 4});
            Console.WriteLine("ArrayList values:");
            PrintArrayListElements(arrayList);

            arrayList.Insert(3, 10);
            Console.WriteLine("ArrayList values after inserts '10' to position '3':");
            PrintArrayListElements(arrayList);

            arrayList.Remove(10);
            Console.WriteLine("ArrayList values after removes first occurrence of value '10':");
            PrintArrayListElements(arrayList);
        }
        private void PrintArrayListElements(System.Collections.ArrayList arrayList)
        {
            foreach (var element in arrayList)
            {
                Console.WriteLine(element);
            }
        }
    }
}