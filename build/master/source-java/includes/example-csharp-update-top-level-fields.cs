var collection = _database.GetCollection<BsonDocument>("restaurants");
var filter = Builders<BsonDocument>.Filter.Eq("name", "Juni");
var update = Builders<BsonDocument>.Update
    .Set("cuisine", "American (New)")
    .CurrentDate("lastModified");
var result = await collection.UpdateOneAsync(filter, update);
