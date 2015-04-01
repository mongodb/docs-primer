var collection = _database.GetCollection<BsonDocument>("restaurants");
var builder = Builders<BsonDocument>.Filter;
var filter = builder.Eq("address.zipcode", "10016") & builder.Eq("cuisine", "Other");
var update = Builders<BsonDocument>.Update
    .Set("cuisine", "Category To Be Determined")
    .CurrentDate("lastModified");
var result = await collection.UpdateManyAsync(filter, update);
