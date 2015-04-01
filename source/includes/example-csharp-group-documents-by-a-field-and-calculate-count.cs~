var collection = _database.GetCollection<BsonDocument>("restaurants");
var aggregate = collection.Aggregate().Group(new BsonDocument { { "_id", "$borough" }, { "count", new BsonDocument("$sum", 1) } });
var results = await aggregate.ToListAsync();
