MongoDB can perform aggregation operations, such as grouping by a
specified key and evaluating a total or a count for each distinct group.

You can use the aggregate_ method to
perform a stage-based aggregation. The
aggregate_ method accepts as its argument a pipeline_
of stages, where each :manual:`stage
</meta/aggregation-quick-reference>`, processed sequentially, describes
a data processing step.

.. _aggregate: http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1collection.html#aa93a46c9e07878fbddeb3ca29af71fc4
.. _pipeline: http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1pipeline.html

