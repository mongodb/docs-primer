You can use the find_ method to issue a query to retrieve data from a
collection in MongoDB. All queries in MongoDB have the scope of a
single collection.

Queries can return all documents in a collection or only the
documents that match a specified filter or criteria. You can specify
the filter or criteria in a `bsoncxx::builder::stream::document`_ and pass as a parameter to the
find_ method.

The find_ method returns query results in a cursor, which is
an iterable object that yields documents.

.. _find: http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1collection.html#a3e32792798315fdb342a7e5903ac6246
.. _`bsoncxx::builder::stream::document`: http://mongodb.github.io/mongo-cxx-driver/classbsoncxx_1_1builder_1_1stream_1_1document.html


