You can use the :method:`~db.collection.find()` method to issue a query to retrieve data from a
collection in MongoDB. All queries in MongoDB have the scope of a
single collection.

Queries can return all documents in a collection or only the
documents that match a specified filter or criteria. You can specify
the filter or criteria in a document and pass as a parameter to the
:method:`~db.collection.find()` method.

The :method:`~db.collection.find()` method returns query results in a cursor, which is
an iterable object that yields documents.

