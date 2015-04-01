You can use the update_one_ method, update_many_ method, and replace_one_ method to update documents of a
collection. The methods accept the following parameters:

- a filter document to match the documents to update,

- an update document to specify the modification to perform, and

- an options parameter (optional).

To specify the filter, use the same structure and syntax as
the query conditions. See :doc:`/query` for an introduction to query
conditions.


You cannot update the ``_id`` field.

.. _update_one: http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1model_1_1update__one.html

.. _update_many: http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1model_1_1update__many.html

.. _replace_one: http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1model_1_1replace__one.html


