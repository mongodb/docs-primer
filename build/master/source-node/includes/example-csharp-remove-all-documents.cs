var collection = _database.GetCollection<BsonDocument>("restaurants");
var filter = new BsonDocument();
var result = await collection.DeleteManyAsync(filter);
