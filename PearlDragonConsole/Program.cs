﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;


namespace PearlDragonConsole
{
    class Program
    {
        private IMongoDatabase _db;
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Customer");

            var document = new BsonDocument
            {

            };


        }
    }
}
