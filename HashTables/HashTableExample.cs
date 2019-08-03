using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructureOverview.Hashtables
{
    public class HashTableExample
    { 
        public void Run()
        {
            Hashtable phoneBook = new Hashtable()
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
        
        private void PrintElements(Hashtable hashtable)
        {
            foreach(DictionaryEntry element in hashtable)
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }
        }
    }
}