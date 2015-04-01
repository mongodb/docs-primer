Insert a document into a collection named ``restaurants``. The operation
will create the collection if the collection does not currently exist.

To specify a document, use the org.bson.Document_ class.

.. literalinclude:: includes/example-java-insert-a-document.java
   :language: java

.. include:: includes/example-java-insert-a-document-post.rst


If the document passed to the insertOne_ method does not contain the
``_id`` field, the driver automatically adds the field to the document
and sets the field's value to a generated :manual:`ObjectId
</reference/object-id>`.
