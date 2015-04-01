FindIterable<Document> iterable = db.getCollection("restaurants").find()
        .sort(new Document("borough", 1).append("address.zipcode", 1));
