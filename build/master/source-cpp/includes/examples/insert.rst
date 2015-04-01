Insert a document into a collection named ``restaurants``. The operation
will create the collection if the collection does not currently exist.

.. literalinclude:: includes/example-cpp-insert-a-document.cpp
   :language: cpp


If the document passed to the insert_one_ method does not contain the
``_id`` field, the driver automatically adds the field to the document
and sets the field's value to a generated :manual:`ObjectId
</reference/object-id>`.
