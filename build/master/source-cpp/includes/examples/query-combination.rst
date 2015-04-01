Logical ``AND``
~~~~~~~~~~~~~~~

You can specify a logical conjunction (``AND``) for a list of query
conditions by inserting (i.e. ``<<``) multiple query conditions to the
query document.

.. literalinclude:: includes/example-cpp-query-logical-and.cpp
   :language: cpp

The result set includes only the documents that matched all specified
criteria.



Logical ``OR``
~~~~~~~~~~~~~~

You can specify a logical disjunction (``OR``) for a list of query
conditions by using the :query:`$or` query operator.

.. literalinclude:: includes/example-cpp-query-logical-or.cpp
   :language: cpp

The result set includes only the documents that match either conditions.

