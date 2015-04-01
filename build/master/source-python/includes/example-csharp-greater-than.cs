var collection = _database.GetCollection<BsonDocument>("restaurants");
var filter = Builders<BsonDocument>.Filter.Gt("grades.score", 30);
var result = await collection.Find(filter).ToListAsync();
