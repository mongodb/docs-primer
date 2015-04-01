AggregateIterable<Document> iterable = db.getCollection("restaurants").aggregate(asList(
        new Document("$match", new Document("borough", "Queens").append("cuisine", "Brazilian")),
        new Document("$group", new Document("_id", "$address.zipcode").append("count", new Document("$sum", 1)))));
