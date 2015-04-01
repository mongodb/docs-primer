Func<BsonDocument, BsonDocument> keyFunc = document => new BsonDocument { { "borough", document["borough"] }, { "address.zipcode", document.GetValue("address.zipcode", "") } };
IsInAscendingOrder(result, keyFunc).Should().BeTrue();
