var collection = _database.GetCollection<BsonDocument>("restaurants");
var filter = Builders<BsonDocument>.Filter.Eq("grades.grade", "B");
var result = await collection.Find(filter).ToListAsync();
