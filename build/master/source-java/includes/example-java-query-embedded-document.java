FindIterable<Document> iterable = db.getCollection("restaurants").find(
        new Document("address.zipcode", "10075"));
