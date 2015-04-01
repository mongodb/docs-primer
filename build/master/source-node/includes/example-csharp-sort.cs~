var collection = _database.GetCollection<BsonDocument>("restaurants");
var filter = new BsonDocument();
var sort = Builders<BsonDocument>.Sort.Ascending("borough").Ascending("address.zipcode");
var result = await collection.Find(filter).Sort(sort).ToListAsync();
