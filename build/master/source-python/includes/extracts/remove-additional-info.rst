In the PyMongo documentation, see :py:meth:`~pymongo.collection.Collection.delete_one`, :py:meth:`~pymongo.collection.Collection.delete_many` and :py:meth:`~pymongo.collection.Collection.drop`.

In MongoDB, write operations are atomic on the level of a single
document. If a single remove operation removes multiple documents from
a collection, the operation can interleave with other write operations
on that collection. In the MongoDB Manual, see
:manual:`Atomicity </core/write-operations-atomicity>`.

