MongoDB provides operators to specify query conditions, such as
:manual:`comparison operators </reference/operators/query-comparison>`.
Although there are some exceptions, such as the :query:`$or` and
:query:`$and` conditional operators, query conditions using operators
generally have the following form:


.. code-block:: none

   new Document( <field>, new Document( <operator>, <value> ) )


To help specify the query condition, the Java driver also provides
the Filters_ class. The class contains various static methods to
simplify building the query predicates, including the lt_ (less
than) and gt_ (greater than) methods:

.. code-block:: java

   lt(<field>, <value>)
   gt(<field>, <value>)

.. _lt: http://api.mongodb.org/java/3.0/com/mongodb/client/model/Filters.html#lt-java.lang.String-TItem-
.. _gt: http://api.mongodb.org/java/3.0/com/mongodb/client/model/Filters.html#gt-java.lang.String-TItem-


