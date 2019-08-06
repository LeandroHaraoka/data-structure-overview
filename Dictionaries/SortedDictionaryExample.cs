using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructureOverview.Dictionaries
{
    public class SortedDictionaryExample
    { 
           public void Run()
        {
            var phoneBook =  new SortedDictionary<string, string>()
            {
                {"Larissa", "(11) 94826-5436"},
                {"Manuel", "(11) 95883-1853"},
                {"Fernando", "(11) 93057-1779"}
            };

            phoneBook["Ana"] = "(11) 91244-2323";

            PrintElements(phoneBook);
        }
        
        private void PrintElements(SortedDictionary<string,string> dictionary)
        {
            foreach(KeyValuePair<string, string> element in dictionary)
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }
        }
    }
}