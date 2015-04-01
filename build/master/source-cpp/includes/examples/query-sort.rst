To specify an order for the result set, pass to the find_ method a sort
option to specify the sort order. The sort options take a document that
contains the field(s) to sort by and the corresponding sort type, e.g.
``1`` for ascending and ``-1`` for descending.

For example, the following operation returns all documents in the
``restaurants`` collection, sorted first by the ``borough`` field in
ascending order, and then, within each borough, by the
``"address.zipcode"`` field in ascending order

.. literalinclude:: includes/example-cpp-query-sort.cpp
   :language: cpp

The operation returns the results sorted in the specified order.

