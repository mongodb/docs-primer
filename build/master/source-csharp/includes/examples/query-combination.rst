Logical ``AND``
~~~~~~~~~~~~~~~

You can specify a logical conjunction (``AND``) for a list of query
conditions by joining the conditions with an ampersand (e.g. ``&``).

.. literalinclude:: includes/example-csharp-logical-and.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-logical-and-results.rst

.. include:: /includes/fact-count-discrepancies.rst

The result set includes only the documents that matched all specified
criteria.



Logical ``OR``
~~~~~~~~~~~~~~

You can specify a logical disjunction (``OR``) for a list of query
conditions by joining the conditions with a pipe (e.g. ``|``).

.. literalinclude:: includes/example-csharp-logical-or.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-logical-or-results.rst

.. include:: /includes/fact-count-discrepancies.rst

The result set includes only the documents that match either conditions.

