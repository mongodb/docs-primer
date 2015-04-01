Greater Than Operator (``$gt``)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Query for documents whose ``grades`` array contains an embedded document
with a field ``score`` greater than ``30``.

.. literalinclude:: includes/example-csharp-greater-than.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-greater-than-results.rst
   :language: csharp

.. include:: /includes/fact-count-discrepancies.rst

The result set includes only the matching documents.



Less Than Operator (``$lt``)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Query for documents whose ``grades`` array contains an embedded document
with a field ``score`` less than ``10``.

.. literalinclude:: includes/example-csharp-less-than.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-less-than-results.rst
   :language: csharp

.. include:: /includes/fact-count-discrepancies.rst

The result set includes only the matching documents.

