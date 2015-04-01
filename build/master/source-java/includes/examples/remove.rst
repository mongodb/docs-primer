Remove All Documents That Match a Condition
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

The following operation removes all documents that match the specified
condition.

.. literalinclude:: includes/example-java-remove-matching-documents.java
   :language: java

.. include:: includes/example-java-remove-matching-documents-post.rst



Remove All Documents
~~~~~~~~~~~~~~~~~~~~

To remove all documents from a collection, pass an empty conditions
document ``{}`` to the deleteMany_ method.

.. literalinclude:: includes/example-java-remove-all-documents.java
   :language: java

.. include:: includes/example-java-remove-all-documents-post.rst



Drop a Collection
~~~~~~~~~~~~~~~~~

The remove all operation only removes the documents from the collection.
The collection itself, as well as any indexes for the collection,
remain.  To remove all documents from a collection, it may be more
efficient to drop the entire collection, including the indexes, and then
recreate the collection and rebuild the indexes.  Use the drop_ method
to drop a collection, including any indexes.

.. literalinclude:: includes/example-java-drop-collection.java
   :language: java

