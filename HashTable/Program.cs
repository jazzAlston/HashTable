using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace HashTables
{
    class Program
    {
        
        static Hashtable  newUser;
        static void Main(string[] args)
        {
            newUser = new Hashtable();

            for (int i = 0; i < 10; i++)
            {
                newUser.Add(i, "user" + i);
            }
            if (newUser.ContainsKey(0))
            {
                newUser.Remove(0);
            }

            if (newUser.ContainsKey(1))
            {
                newUser[1] = "somesStuff";
            }
            foreach (DictionaryEntry entry in newUser)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }
            Dictionary<string, int> someDic = new Dictionary<string, int>() {

                ["John"] = 23,
                ["Kate"] = 23,
                ["Chris"] = 23,
                ["Steve"] = 23,
                ["Johan"] = 47



            };

            
            foreach (KeyValuePair<string, int> kvp in someDic)
            {

                string someKey = kvp.Key;
                Console.WriteLine(kvp);
                Thread.Sleep(5000);
                Console.Clear();
                Console.Write(someKey);

            }
            var result = from key in someDic
                         where key.Key.StartsWith("Jo")
                         select key;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
