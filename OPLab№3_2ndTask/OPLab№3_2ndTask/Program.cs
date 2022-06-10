using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace OPLab_3_2ndTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, object>[] storage = new Dictionary<string, object>[3];

            storage[0] = new Dictionary<string, object>();
            storage[1] = new Dictionary<string, object>();
            storage[2] = new Dictionary<string, object>();

            storage[0].Add("Id", 1);
            storage[0].Add("success", true);
            storage[0].Add("Name", "Oleh");

            int a1 = (int)storage[0]["Id"];
            bool b1 = (bool)storage[0]["success"];
            string c1 = (string)storage[0]["Name"];

            storage[1].Add("Id", 2);
            storage[1].Add("success", false);
            storage[1].Add("Name", "Roma");

            int a2 = (int)storage[1]["Id"];
            bool b2 = (bool)storage[1]["success"];
            string c2 = (string)storage[1]["Name"];

            storage[2].Add("Id", 3);
            storage[2].Add("success", true);
            storage[2].Add("Name", "Sasha");

            int a3 = (int)storage[2]["Id"];
            bool b3 = (bool)storage[2]["success"];
            string c3 = (string)storage[2]["Name"];

            Console.WriteLine("The initial amount is: {0}", storage.Length);

            var ListOfDictionaries = new List<Dictionary<string, object>>();

            foreach (Dictionary<string, object> results in storage)
            {
                if (results.ContainsValue(true))
                { 

                ListOfDictionaries.Add(results);

                }
            }
                Console.WriteLine("Number of people who has True:{0}", ListOfDictionaries.Count);
                string fileName = "ListOfDictionaries.json";
                string jsonString = JsonSerializer.Serialize(ListOfDictionaries);
                File.WriteAllText(fileName, jsonString);

        }
    }
}
