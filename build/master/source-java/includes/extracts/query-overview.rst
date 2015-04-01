You can use the find_ method to issue a query to retrieve data from a
collection in MongoDB. All queries in MongoDB have the scope of a
single collection.

Queries can return all documents in a collection or only the
documents that match a specified filter or criteria. You can specify
the filter or criteria in a org.bson.Document_ and pass as a parameter to the
find_ method.

The find_ method returns query results in a FindIterable_, which is
an iterable object that yields documents.

.. _find: http://api.mongodb.org/java/3.0/com/mongodb/client/MongoCollection.html#find--
.. _FindIterable: http://api.mongodb.org/java/3.0/com/mongodb/client/FindIterable.html
.. _org.bson.Document: http://api.mongodb.org/java/3.0/org/bson/Document.html
.. _append: http://api.mongodb.org/java/3.0/org/bson/Document.html#append-java.lang.String-java.lang.Object-


