db.getCollection("restaurants").updateOne(new Document("name", "Juni"),
        new Document("$set", new Document("cuisine", "American (New)"))
            .append("$currentDate", new Document("lastModified", true)));
