MongoDB can perform aggregation operations, such as grouping by a
specified key and evaluating a total or a count for each distinct group.

Use the `aggregate <http://mongodb.github.io/node-mongodb-native/2.0/api/Collection.html#aggregate>`_ method to
perform a stage-based aggregation. The
`aggregate <http://mongodb.github.io/node-mongodb-native/2.0/api/Collection.html#aggregate>`_ method accepts as its argument an
array of stages, where each :manual:`stage
</meta/aggregation-quick-reference>`, processed sequentially, describes
a data processing step.


.. code-block:: javascript

   db.collection.aggregate( [ <stage1>, <stage2>, ... ] )


