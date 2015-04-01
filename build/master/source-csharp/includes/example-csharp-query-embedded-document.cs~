var collection = _database.GetCollection<BsonDocument>("restaurants");
var filter = Builders<BsonDocument>.Filter.Eq("address.zipcode", "10075");
var result = await collection.Find(filter).ToListAsync();
