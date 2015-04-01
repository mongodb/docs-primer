You can use the :py:meth:`~pymongo.collection.Collection.delete_one` method and the :py:meth:`~pymongo.collection.Collection.delete_many` method to remove
documents from a collection. The method takes a conditions document
that determines the documents to remove.

To specify a remove condition, use the same structure and syntax as the
query conditions. See :doc:`/query` for an introduction to query
conditions.

