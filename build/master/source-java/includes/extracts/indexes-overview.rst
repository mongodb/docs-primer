.. _createIndex: http://api.mongodb.org/java/3.0/com/mongodb/client/MongoCollection.html#createIndex-org.bson.conversions.Bson-


Indexes can support the efficient execution of queries. MongoDB
automatically creates an index on the ``_id`` field upon the
creation of a collection.

Use the createIndex_ method to create an
index on a collection. Indexes can support the efficient execution of
queries. MongoDB automatically creates an index on the ``_id`` field
upon the creation of a collection.

To create an index on a field or fields, pass to the createIndex_
method an index key specification document (org.bson.Document_) that
contains the fields to index and the index type for each field:

.. code-block:: javascript

   new Document(<field1>, <type1>).append(<field2>, <type2>) ...

- For an ascending index type, specify ``1`` for ``<type>``.
- For a descending index type, specify ``-1`` for ``<type>``.

createIndex_ only creates an index if the index does not exist.

.. _org.bson.Document: http://api.mongodb.org/java/3.0/org/bson/Document.html

