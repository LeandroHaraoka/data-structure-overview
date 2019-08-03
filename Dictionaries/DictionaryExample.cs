using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructureOverview.Dictionaries
{
    public class DictionaryExample
    { 
        public void Run()
        {
            Dictionary<string, string> phoneBook =  new Dictionary<string, string>()
            {
                {"Larissa", "(11) 94826-5436"},
                {"Manuel", "(11) 95883-1853"},
                {"Fernando", "(11) 93057-1779"}
            };

            phoneBook["Larissa"] = "(11) 99999-5555";

            if(!phoneBook.ContainsKey("Larissa"))
                phoneBook.Add("Larissa", "(11) 96666-4533");

            PrintElements(phoneBook);
        }
        
        private void PrintElements(Dictionary<string,string> dictionary)
        {
            foreach(KeyValuePair<string, string> element in dictionary)
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }
        }
    }
}