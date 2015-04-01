Insert a document into a collection named ``restaurants``. The operation
will create the collection if the collection does not currently exist.

.. literalinclude:: includes/example-csharp-insert-a-document.cs
   :language: csharp

.. include:: includes/example-csharp-insert-a-document-post.rst


If the document passed to the InsertOneAsync_ method does not contain
the ``_id`` field, the driver automatically adds the field to the
document and sets the field's value to a generated :manual:`ObjectId
</reference/object-id>`.
