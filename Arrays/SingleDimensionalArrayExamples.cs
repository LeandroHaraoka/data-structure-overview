using System;

namespace DataStructureOverview.Arrays
{
    public class SingleDimensionalArrayExamples
    {
        public void Run()
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
            
            // Printa cada elemento da array
            Console.WriteLine("IntegerNumberArray: ");
            PrintArrayElements(integerNumberArray);
            Console.WriteLine("StringArray: ");
            PrintArrayElements(stringArray);
            Console.WriteLine("DateArray: ");
            PrintArrayElements(dateArray);
            Console.WriteLine("");

            // Copia a array integerNumberArray para a destinationArray
            // na posicao 3
            var destinationArray = new int[10];
            integerNumberArray.CopyTo(destinationArray,3);
            Console.WriteLine($"Copies integerNumberArray to a new array with length {destinationArray.GetLength(0)}.");
            PrintArrayElements(destinationArray);
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