using (var cursor = await collection.Indexes.ListAsync())
{
    var indexes = await cursor.ToListAsync();
    indexes.Should().Contain(index => index["name"] == "cuisine_1_address.zipcode_1");
}
