You can use the updateOne_ method, updateMany_ method, and replaceOne_ method to update documents of a
collection. The methods accept the following parameters:

- a filter document to match the documents to update,

- an update document to specify the modification to perform, and

- an options parameter (optional).

To specify the filter, use the same structure and syntax as
the query conditions. See :doc:`/query` for an introduction to query
conditions.


You cannot update the ``_id`` field.

.. _updateOne: http://api.mongodb.org/java/3.0/com/mongodb/client/MongoCollection.html#updateOne-org.bson.conversions.Bson-org.bson.conversions.Bson-

.. _updateMany: http://api.mongodb.org/java/3.0/com/mongodb/client/MongoCollection.html#updateMany-org.bson.conversions.Bson-org.bson.conversions.Bson-

.. _replaceOne: http://api.mongodb.org/java/3.0/com/mongodb/client/MongoCollection.html#replaceOne-org.bson.conversions.Bson-TDocument-


