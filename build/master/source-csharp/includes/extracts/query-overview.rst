You can use the Find_ and FindAsync_ methods to issue a query
to retrieve data from a collection in MongoDB. All queries in
MongoDB have the scope of a single collection.

Queries can return all documents in a collection or only the
documents that match a specified filter or criteria. You can specify
the filter or criteria in a BsonDocument_ and pass as a parameter to the
Find_ and FindAsync_ methods.

The FindAsync_ method returns query results in a IAsyncCursor_, which is
an iterable object that yields documents.

The Find_ method returns a IFindFluent_ object. You can
use the ToListAsync_ method to return the results as a list that
contains all the documents returned by the cursor. ToListAsync_ requires
holding the entire result set in memory.

.. _Find: http://api.mongodb.org/csharp/2.0.0/html/b95c35fa-bf8a-957e-b9e7-0d73a705cb2e.htm
.. _FindAsync: http://api.mongodb.org/csharp/2.0.0/html/8448c4cd-d9ab-e229-0e99-e5e9bdc15d64.htm
.. _IAsyncCursor: http://api.mongodb.org/csharp/2.0.0/html/a59d0e6e-deb2-f8de-deba-adecc11eb383.htm
.. _IFindFluent: http://api.mongodb.org/csharp/2.0.0/html/9263632e-d133-135c-7b27-e3106482072f.htm
.. _ToListAsync: http://api.mongodb.org/csharp/2.0.0/html/e840b5c3-bfa4-4bb6-3c27-67a2f194f6bb.htm
.. _BsonDocument: http://api.mongodb.org/csharp/2.0.0/html/3a31e174-4df4-91f3-6760-02078b53ddb1.htm
.. _SortDefinitionBuilder: http://api.mongodb.org/csharp/2.0.0/html/abcb0daf-4aab-e884-b772-9e5df303c67c.htm
.. _Ascending: http://api.mongodb.org/csharp/2.0.0/html/38738571-6d69-5cb9-711a-78e1b0d5aab6.htm
.. _Descending: http://api.mongodb.org/csharp/2.0.0/html/4b89a669-5e15-f215-acf1-a8b70c1a4965.htm


