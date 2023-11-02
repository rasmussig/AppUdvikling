using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB_CSharp_In_Class.Storage
{
    public class Persistency
    {
        private string connectionString = "mongodb+srv://rasmussig:kagemand123@cluster0.6vg8bbv.mongodb.net/";

        IMongoClient dbClient;

        IMongoDatabase database;

        //= dbClient.GetDatabase("ansattedb");

        IMongoCollection<BsonDocument> collection;

        public Persistency()
        {
            dbClient = new MongoClient(connectionString);

            database = dbClient.GetDatabase("ansattedb");

            collection = database.GetCollection<BsonDocument>("projects");
        }

        public void opretteAnsat(BsonDocument ansatte)
        {
            collection.InsertOne(ansatte);
        }

        public List<BsonDocument> GetAll()
        {
            return collection.Find(new BsonDocument()).ToList();
        }

    }
}
