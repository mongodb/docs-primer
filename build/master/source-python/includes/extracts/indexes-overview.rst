Indexes can support the efficient execution of queries. MongoDB
automatically creates an index on the ``_id`` field upon the
creation of a collection.

Use the :py:meth:`~pymongo.collection.Collection.create_index()` method to create an
index on a collection. Indexes can support the efficient execution of
queries. MongoDB automatically creates an index on the ``_id`` field
upon the creation of a collection.

To create an index on a field or fields, pass to the
method a list of field and index type pairs:

.. code-block:: javascript

   [ ( <field1>: <type1> ), ... ]

- For an ascending index, specify ``pymongo.ASCENDING`` for ``<type>``.
- For a descending index, specify ``pymongo.DESCENDING`` for ``<type>``.

:py:meth:`~pymongo.collection.Collection.create_index()` only creates
an index if the index does not exist.


