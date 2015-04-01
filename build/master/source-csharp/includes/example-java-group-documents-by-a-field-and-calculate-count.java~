AggregateIterable<Document> iterable = db.getCollection("restaurants").aggregate(asList(
        new Document("$group", new Document("_id", "$borough").append("count", new Document("$sum", 1)))));
