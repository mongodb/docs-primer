You can use the updateOne_ method, updateMany_ method, and replaceOne_ method to update documents of a
collection. The methods accept the following parameters:

- a filter document to match the documents to update,

- an update document to specify the modification to perform, and

- an options parameter (optional).

To specify the filter, use the same structure and syntax as
the query conditions. See :doc:`/query` for an introduction to query
conditions.


You cannot update the ``_id`` field.

.. _updateOne: http://mongodb.github.io/node-mongodb-native/2.0/api/Collection.html#updateOne

.. _updateMany: http://mongodb.github.io/node-mongodb-native/2.0/api/Collection.html#updateMany

.. _replaceOne: http://mongodb.github.io/node-mongodb-native/2.0/api/Collection.html#replaceOne


