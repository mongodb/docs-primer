Logical ``AND``
~~~~~~~~~~~~~~~

You can specify a logical conjunction (``AND``) for multiple query
conditions by appending conditions to the query document. See the
append_ method in the org.bson.Document_ class.

.. literalinclude:: includes/example-java-logical-and.java
   :language: java

The result set includes only the documents that matched all specified
criteria.

.. include:: includes/example-java-logical-and-pre1.rst

.. literalinclude:: includes/example-java-logical-and-pre1.java
   :language: java

.. include:: includes/fact-java-filters-helpers.rst

.. literalinclude:: includes/example-java-logical-and-pre2.java
   :language: java





Logical ``OR``
~~~~~~~~~~~~~~

You can specify a logical disjunction (``OR``) for a list of query
conditions by using the :query:`$or` query operator.

.. literalinclude:: includes/example-java-logical-or.java
   :language: java

The result set includes only the documents that match either conditions.

.. include:: includes/example-java-logical-or-pre1.rst

.. literalinclude:: includes/example-java-logical-or-pre1.java
   :language: java

.. include:: includes/fact-java-filters-helpers.rst

.. literalinclude:: includes/example-java-logical-or-pre2.java
   :language: java



