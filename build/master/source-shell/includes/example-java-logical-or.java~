FindIterable<Document> iterable = db.getCollection("restaurants").find(
        new Document("$or", asList(new Document("cuisine", "Italian"),
                new Document("address.zipcode", "10075"))));
