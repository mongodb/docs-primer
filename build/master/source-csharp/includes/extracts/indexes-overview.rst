.. _IMongoIndexManager.CreateOneAsync: http://api.mongodb.org/csharp/2.0.0/html/96a9b8cf-8df5-398f-8e26-ff1b4be6292b.htm
.. _IndexKeysDefinitionBuilder: http://api.mongodb.org/csharp/2.0.0/html/39b2c41c-25e1-7d79-4a80-a074ee7fc35e.htm
.. _Ascending: http://api.mongodb.org/csharp/2.0.0/html/765c812c-34b9-66dd-fd37-2cf54731b47a.htm
.. _Descending: http://api.mongodb.org/csharp/2.0.0/html/fa02e4e1-d520-7993-08ee-5cf7973adeee.htm
.. _CreateIndexOptions: http://api.mongodb.org/csharp/2.0.0/html/539c76c8-a1bc-bc58-3a88-e2316915153f.htm


Indexes can support the efficient execution of queries. MongoDB
automatically creates an index on the ``_id`` field upon the
creation of a collection.

Use the `IMongoIndexManager.CreateOneAsync`_ method to create an
index on a collection. Indexes can support the efficient execution of
queries. MongoDB automatically creates an index on the ``_id`` field
upon the creation of a collection.

To create an index on a field or fields, pass to the `IMongoIndexManager.CreateOneAsync`_
method an index key specification. With the C# MongoDB driver, use
the methods available in the IndexKeysDefinitionBuilder_ class to
specify the index key specification.

.. code-block:: javascript

   var keys = Builders<BsonDocument>.IndexKeys.Ascending(<field1>).Ascending(<field2>);
   await collection.Indexes.CreateOneAsync(keys);

- For an ascending index type, use the Ascending_ method.
- For a descending index type, use the Descending_ method.

`IMongoIndexManager.CreateOneAsync`_ only creates an index if the index does not exist.

