using System;
using System.Collections;

namespace DataStructureOverview.Arrays
{
    public class ArrayListExamples
    { 
        public void Run()
        {
            var arrayList = new ArrayList();
            arrayList.Add("Numbers");
            arrayList.Add(1);
            arrayList.AddRange(new int[] {2, 3, 4});
            Console.WriteLine("ArrayList values:");
            PrintArrayListElements(arrayList);
            Console.WriteLine("");

            arrayList.Insert(3, 10);
            Console.WriteLine("ArrayList values after inserts '10' to position '3':");
            PrintArrayListElements(arrayList);
            Console.WriteLine("");

            arrayList.Remove(10);
            Console.WriteLine("ArrayList values after removes first occurrence of value '10':");
            PrintArrayListElements(arrayList);
        }
        private void PrintArrayListElements(ArrayList arrayList)
        {
            foreach (var element in arrayList)
            {
                Console.WriteLine(element);
            }
        }
    }
}