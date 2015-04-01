var collection = _database.GetCollection<BsonDocument>("restaurants");
var builder = Builders<BsonDocument>.Filter;
var filter = builder.Eq("cuisine", "Italian") & builder.Eq("address.zipcode", "10075");
var result = await collection.Find(filter).ToListAsync();
