using System;

namespace DataStructureOverview.Arrays
{
    public class SingleDimensionalArray
    {
        public void RunExamples()
        {
            // Cria arrays
            var integerNumberArray = new int[] {1 ,2 ,3 ,4 ,5};
            var stringArray = new string[] {"Pedro", "Maria", "Ana", "Felipe"};
            var dateArray = new DateTime[] 
            {
                new DateTime(2019, 01, 01),
                new DateTime(2018, 01, 01),
                new DateTime(2017, 01, 01),
                new DateTime(2016, 01, 01)
            };
            
            // Printa a array
            Console.WriteLine("Ao printar o objeto array temos: ");
            Console.WriteLine(integerNumberArray);
            Console.WriteLine(stringArray);
            Console.WriteLine(dateArray);
            Console.WriteLine("");
            
            // Printa cada elemento da array
            Console.WriteLine("Ao printar cada elemento da array temos: ");
            PrintArrayElements(integerNumberArray);
            PrintArrayElements(stringArray);
            PrintArrayElements(dateArray);
            Console.WriteLine("");

            // Usando o CopyTo
            //  var copyToArray = new int[10];
            //  integerNumberArray.CopyTo(copyToArray,5);
            // Console.WriteLine("Resultado do CopyTo: ");
            // PrintArrayElements(copyToArray);

            // Usando o Copy
            // var copyArray = new int[10];
            // Array.Copy(integerNumberArray, 0, copyArray, 2, 3);
            // Console.WriteLine("Resultado do Copy: ");
            // PrintArrayElements(copyArray);
        }

        private void PrintArrayElements(Array array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}