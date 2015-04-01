.. _create_index: http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1collection.html#a0e31354056b3453589d039f2d1b604a8


Indexes can support the efficient execution of queries. MongoDB
automatically creates an index on the ``_id`` field upon the
creation of a collection.

Use the create_index_ method to create an
index on a collection. Indexes can support the efficient execution of
queries. MongoDB automatically creates an index on the ``_id`` field
upon the creation of a collection.

To create an index on a field or fields, pass to the create_index_
method an index key specification document
(`bsoncxx::builder::stream::document`_) that contains the fields to
index and the index type for each field:

.. code-block:: javascript

   document index_spec;
   index_spec << field1 << type1 << field2 << type2 ...

- For an ascending index type, specify ``1`` for ``type``.
- For a descending index type, specify ``-1`` for ``type``.

create_index_ only creates an index if the index does not exist.

.. _`bsoncxx::builder::stream::document`: http://mongodb.github.io/mongo-cxx-driver/classbsoncxx_1_1builder_1_1stream_1_1document.html

