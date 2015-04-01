Remove All Documents That Match a Condition
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

The following operation removes all documents that match the specified
condition.

.. literalinclude:: includes/example-csharp-remove-matching-documents.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-remove-matching-documents-results.rst

.. include:: /includes/fact-count-discrepancies.rst



Remove All Documents
~~~~~~~~~~~~~~~~~~~~

To remove all documents from a collection, pass an empty conditions
document to the DeleteManyAsync_ method.

.. literalinclude:: includes/example-csharp-remove-all-documents.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-remove-all-documents-results.rst
   :language: csharp

.. include:: /includes/fact-count-discrepancies.rst



Drop a Collection
~~~~~~~~~~~~~~~~~

The remove all operation only removes the documents from the collection.
The collection itself, as well as any indexes for the collection,
remain.  To remove all documents from a collection, it may be more
efficient to drop the entire collection, including the indexes, and then
recreate the collection and rebuild the indexes.  Use the
DropCollectionAsync_ method to drop a collection, including any indexes.

.. literalinclude:: includes/example-csharp-drop-collection.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-drop-collection-results.rst
   :language: csharp

