To specify an order for the result set, pass to the Sort_ method the
sort specification document. Use the methods available in the
SortDefinitionBuilder_ class (e.g. Ascending_ or the Descending_ method)
to implement the sort specification document.

For example, the following operation returns all documents in the
``restaurants`` collection, sorted first by the ``borough`` field in
ascending order, and then, within each borough, by the
``"address.zipcode"`` field in ascending order

.. literalinclude:: includes/example-csharp-sort.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-sort-results.rst
   :language: csharp



