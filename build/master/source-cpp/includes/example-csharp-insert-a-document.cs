var document = new BsonDocument
{
    { "address" , new BsonDocument
        {
            { "street", "2 Avenue" },
            { "zipcode", "10075" },
            { "building", "1480" },
            { "coord", new BsonArray { 73.9557413, 40.7720266 } }
        }
    },
    { "borough", "Manhattan" },
    { "cuisine", "Italian" },
    { "grades", new BsonArray
        {
            new BsonDocument
            {
                { "date", new DateTime(2014, 10, 1, 0, 0, 0, DateTimeKind.Utc) },
                { "grade", "A" },
                { "score", 11 }
            },
            new BsonDocument
            {
                { "date", new DateTime(2014, 1, 6, 0, 0, 0, DateTimeKind.Utc) },
                { "grade", "B" },
                { "score", 17 }
            }
        }
    },
    { "name", "Vella" },
    { "restaurant_id", "41704620" }
};

var collection = _database.GetCollection<BsonDocument>("restaurants");
await collection.InsertOneAsync(document);
