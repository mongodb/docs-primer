using (var cursor = await _database.ListCollectionsAsync())
{
    var collections = await cursor.ToListAsync();
    collections.Should().NotContain(document => document["name"] == "restaurants");
}
