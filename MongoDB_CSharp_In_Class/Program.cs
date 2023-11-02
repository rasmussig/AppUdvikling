using MongoDB.Bson;
using MongoDB_CSharp_In_Class.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB_CSharp_In_Class
{
    public class Program
    {
        static void Main(string[] args)
        {

            var doc = new BsonDocument
            {
                {"Name","Rasmus" },
                 {"Email","rasmus2001@live.dk" },
                  {"Tlf","24246503" }
            };

            Persistency persistency = new Persistency();

            Console.WriteLine("---------- Opret ny ansatte --------------");
            persistency.opretteAnsat(doc);

            Console.WriteLine("--------Få alle ansatte------------");           
            var result = persistency.GetAll();

            foreach (var item in result)
            {

                Console.WriteLine(item.ToString());
                //Console.WriteLine("Navn: " + document["Name"]);
                //Console.WriteLine("Email: " + document["Email"]);
                //Console.WriteLine("Tlf: " + document["Tlf"]);
                //Console.WriteLine("----------------------------");
            }

            Console.ReadKey();
        }
    }
}
