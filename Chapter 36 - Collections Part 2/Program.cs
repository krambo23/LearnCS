using System;
using System.Collections;

namespace CollectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("001", "Zara Ali");
            hashTable.Add("002", "Abida Rehman");
            hashTable.Add("003", "Joe Holzner");
            hashTable.Add("004", "Mausam Benazir Nur");
            hashTable.Add("005", "M. Amlan");
            hashTable.Add("006", "M. Arif");
            hashTable.Add("007", "Ritesh Saikia");

            if (hashTable.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                hashTable.Add("008", "Nuha Ali");
            }

            // Get a collection of the keys.
            ICollection key = hashTable.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k + " : " + hashTable[k]);
            }
        }
    }
}