MongoDB can perform aggregation operations, such as grouping by a
specified key and evaluating a total or a count for each distinct group.

Use the aggregate_ method to
perform a stage-based aggregation. The
aggregate_ method accepts as its argument an
array of stages, where each :manual:`stage
</meta/aggregation-quick-reference>`, processed sequentially, describes
a data processing step.

.. _aggregate: http://api.mongodb.org/java/3.0/com/mongodb/client/MongoCollection.html#aggregate-java.util.List-


