var expectedResults = new[]
{
    BsonDocument.Parse("{ _id : 'Staten Island', count : 969 }"),
    BsonDocument.Parse("{ _id : 'Brooklyn', count : 6086 }"),
    BsonDocument.Parse("{ _id : 'Manhattan', count : 10259 }"),
    BsonDocument.Parse("{ _id : 'Queens', count : 5656 }"),
    BsonDocument.Parse("{ _id : 'Bronx', count : 2338 }"),
    BsonDocument.Parse("{ _id : 'Missing', count : 51 }")
};
results.Should().BeEquivalentTo(expectedResults);
