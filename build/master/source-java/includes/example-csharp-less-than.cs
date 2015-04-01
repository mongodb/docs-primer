var collection = _database.GetCollection<BsonDocument>("restaurants");
var filter = Builders<BsonDocument>.Filter.Lt("grades.score", 10);
var result = await collection.Find(filter).ToListAsync();
