db.getCollection("restaurants").updateMany(new Document("address.zipcode", "10016").append("cuisine", "Other"),
        new Document("$set", new Document("cuisine", "Category To Be Determined"))
                .append("$currentDate", new Document("lastModified", true)));
