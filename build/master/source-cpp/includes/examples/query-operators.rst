Greater Than Operator (``$gt``)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Query for documents whose ``grades`` array contains an embedded document
with a field ``score`` greater than ``30``.

.. literalinclude:: includes/example-cpp-query-greater-than.cpp
   :language: cpp

The result set includes only the matching documents.



Less Than Operator (``$lt``)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Query for documents whose ``grades`` array contains an embedded document
with a field ``score`` less than ``10``.

.. literalinclude:: includes/example-cpp-query-less-than.cpp
   :language: cpp

The result set includes only the matching documents.

