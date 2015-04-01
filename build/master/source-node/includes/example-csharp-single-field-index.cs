var collection = _database.GetCollection<BsonDocument>("restaurants");
var keys = Builders<BsonDocument>.IndexKeys.Ascending("cuisine");
await collection.Indexes.CreateOneAsync(keys);
