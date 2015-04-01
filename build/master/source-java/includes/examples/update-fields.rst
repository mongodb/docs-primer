Update Top-Level Fields
~~~~~~~~~~~~~~~~~~~~~~~

The following operation updates the first document with ``name`` equal
to ``"Juni"``, using the :update:`$set` operator to update the
``cuisine`` field and the :update:`$currentDate` operator to update the
``lastModified`` field with the current date.

.. literalinclude:: includes/example-java-update-top-level-fields.java
   :language: java

.. include:: includes/example-java-update-top-level-fields-post.rst



Update an Embedded Field
~~~~~~~~~~~~~~~~~~~~~~~~

To update a field within an embedded document, use the :term:`dot
notation`. When using the dot notation, enclose the whole dotted field
name in quotes.  The following updates the ``street`` field in the
embedded ``address`` document.

.. literalinclude:: includes/example-java-update-embedded-field.java
   :language: java

.. include:: includes/example-java-update-embedded-field-post.rst



Update Multiple Documents
~~~~~~~~~~~~~~~~~~~~~~~~~

To update multiple documents, use the updateMany_ method.  The following
operation updates *all* documents that have ``address.zipcode`` field
equal to ``"10016"``, setting the ``borough`` field to ``"Manhattan"``
and the ``lastModified`` field to the current date.

.. literalinclude:: includes/example-java-update-multiple-documents.java
   :language: java

.. include:: includes/example-java-update-multiple-documents-post.rst

