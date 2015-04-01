Remove All Documents That Match a Condition
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

The following operation removes all documents that match the specified
condition.

.. literalinclude:: includes/example-cpp-remove-matching-documents.cpp
   :language: cpp



Use the ``delete_one`` method.
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Use the delete_one_ method to limit the remove operation to only one of
the matching documents

.. literalinclude:: includes/example-cpp-remove-justone.cpp
   :language: cpp



Remove All Documents
~~~~~~~~~~~~~~~~~~~~

To remove all documents from a collection, pass an empty conditions
document ``{}`` to the delete_many_ method.

.. literalinclude:: includes/example-cpp-remove-all-documents.cpp
   :language: cpp



Drop a Collection
~~~~~~~~~~~~~~~~~

The remove all operation only removes the documents from the collection.
The collection itself, as well as any indexes for the collection,
remain.  To remove all documents from a collection, it may be more
efficient to drop the entire collection, including the indexes, and then
recreate the collection and rebuild the indexes.  Use the drop_ method
to drop a collection, including any indexes.

.. literalinclude:: includes/example-cpp-drop-collection.cpp
   :language: cpp

