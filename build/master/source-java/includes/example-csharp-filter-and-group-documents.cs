var collection = _database.GetCollection<BsonDocument>("restaurants");
var aggregate = collection.Aggregate()
    .Match(new BsonDocument { { "borough", "Queens" }, { "cuisine", "Brazilian" } })
    .Group(new BsonDocument { { "_id", "$address.zipcode" }, { "count", new BsonDocument("$sum", 1) } });
var results = await aggregate.ToListAsync();
