To specify an order for the result set, append the `sort()
<http://api.mongodb.org/java/3.0/com/mongodb/async/client/FindIterable.html#sort-org.bson.conversions.Bson->`_
method to the query. Pass to  `sort()
<http://api.mongodb.org/java/3.0/com/mongodb/async/client/FindIterable.html#sort-org.bson.conversions.Bson->`_
method a document which contains the field(s) to sort by and the
corresponding sort type, e.g. ``1`` for ascending and ``-1`` for
descending.

For example, the following operation returns all documents in the
``restaurants`` collection, sorted first by the ``borough`` field in
ascending order, and then, within each borough, by the
``"address.zipcode"`` field in ascending order:

.. literalinclude:: includes/example-java-sort.java
   :language: java

.. include:: includes/example-java-sort-pre1.rst

.. literalinclude:: includes/example-java-sort-pre1.java
   :language: java

.. include:: includes/fact-java-filters-helpers.rst

.. literalinclude:: includes/example-java-sort-pre2.java
   :language: java

The operation returns the results sorted in the specified order.

