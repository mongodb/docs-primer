You can use the :py:meth:`~pymongo.collection.Collection.update_one` and the :py:meth:`~pymongo.collection.Collection.update_many` methods to update
documents of a collection. The :py:meth:`~pymongo.collection.Collection.update_one` method updates a single
document. Use :py:meth:`~pymongo.collection.Collection.update_many` to update all documents that match the
criteria. The methods accept the following parameters:


- a filter document to match the documents to update,

- an update document to specify the modification to perform, and

- an optional upsert parameter.

To specify the update filter, use the same structure and syntax as
the query conditions. See :doc:`/query` for an introduction to query
conditions.


You cannot update the ``_id`` field.


