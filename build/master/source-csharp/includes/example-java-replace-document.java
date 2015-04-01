db.getCollection("restaurants").replaceOne(new Document("restaurant_id", "41704620"),
        new Document("address",
                new Document()
                        .append("street", "2 Avenue")
                        .append("zipcode", "10075")
                        .append("building", "1480")
                        .append("coord", asList(-73.9557413, 40.7720266)))
                .append("name", "Vella 2"));
