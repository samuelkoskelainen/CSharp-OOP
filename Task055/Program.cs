using System;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Task055
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MainAsync().Wait();
            } catch (AggregateException)
            {
                throw new MyDatabaseConnectionException();
            }

            Console.ReadLine();
        }
        
        static async Task MainAsync()
        {
            var client = new MongoClient("connection string");
            IMongoDatabase db = client.GetDatabase("database");
            var collection = db.GetCollection<BsonDocument>("collection");

          

            using (IAsyncCursor<BsonDocument> CursorType = await collection.FindAsync(new BsonDocument()))
            {
                while(await CursorType.MoveNextAsync())
                {
                    IEnumerable<BsonDocument> batch = CursorType.Current;
                    foreach (BsonDocument document in batch)
                    {
                        Console.WriteLine(document);
                        Console.WriteLine();
                    }
                }
            }
            
        }
    }

    class MyDatabaseConnectionException : Exception
    {
        public MyDatabaseConnectionException()
            : base(String.Format("Connection failed to database, check out the path for errors..."))
        {

        }
    }

}
