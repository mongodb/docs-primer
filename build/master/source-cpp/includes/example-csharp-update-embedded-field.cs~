var collection = _database.GetCollection<BsonDocument>("restaurants");
var filter = Builders<BsonDocument>.Filter.Eq("restaurant_id", "41156888");
var update = Builders<BsonDocument>.Update.Set("address.street", "East 31st Street");
var result = await collection.UpdateOneAsync(filter, update);
