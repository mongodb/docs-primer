var collection = _database.GetCollection<BsonDocument>("restaurants");
var filter = new BsonDocument();
var count = 0;
using (var cursor = await collection.FindAsync(filter))
{
    while (await cursor.MoveNextAsync())
    {
        var batch = cursor.Current;
        foreach (var document in batch)
        {
            // process document
            count++;
        }
    }
}
