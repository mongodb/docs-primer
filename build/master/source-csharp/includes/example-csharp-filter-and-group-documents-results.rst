var expectedResults = new[]
{
    BsonDocument.Parse("{ _id : '11368', count : 1 }"),
    BsonDocument.Parse("{ _id : '11106', count : 3 }"),
    BsonDocument.Parse("{ _id : '11377', count : 1 }"),
    BsonDocument.Parse("{ _id : '11103', count : 1 }"),
    BsonDocument.Parse("{ _id : '11101', count : 2 }")
};
results.Should().BeEquivalentTo(expectedResults);
