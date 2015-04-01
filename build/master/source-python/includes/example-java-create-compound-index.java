db.getCollection("restaurants").createIndex(new Document("cuisine", 1).append("address.zipcode", 1));
