To return all documents in a collection, call the FindAsync_  method
with an *empty* filter document. For example, the following operation
queries for all documents in the ``restaurants`` collection.

.. literalinclude:: includes/example-csharp-query-all.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-query-all-results.rst

.. include:: /includes/fact-count-discrepancies.rst

The result set contains all documents in the ``restaurants`` collection.

