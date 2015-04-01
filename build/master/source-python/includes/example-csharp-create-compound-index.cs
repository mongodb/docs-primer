var collection = _database.GetCollection<BsonDocument>("restaurants");
var keys = Builders<BsonDocument>.IndexKeys.Ascending("cuisine").Ascending("address.zipcode");
await collection.Indexes.CreateOneAsync(keys);
