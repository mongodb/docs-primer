var collection = _database.GetCollection<BsonDocument>("restaurants");
var filter = Builders<BsonDocument>.Filter.Eq("borough", "Manhattan");
var result = await collection.Find(filter).ToListAsync();
