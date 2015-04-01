Update Top-Level Fields
~~~~~~~~~~~~~~~~~~~~~~~

The following operation updates the first document with ``name`` equal
to ``"Juni"``, to update the ``cuisine`` field and the ``lastModified``
field.  To specify a :update:`$set` operation to update the ``cuisine``
field, use the Set_ method of the UpdateDefinitionBuilder_.  To specify
a :update:`$currentDate` operation to update the ``lastModified`` field
with the current date, use the CurrentDate_ method of the
UpdateDefinitionBuilder_.

.. literalinclude:: includes/example-csharp-update-top-level-fields.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-update-top-level-fields-results.rst
   :language: csharp



Update an Embedded Field
~~~~~~~~~~~~~~~~~~~~~~~~

To update a field within an embedded document, use the :term:`dot
notation`. When using the dot notation, enclose the whole dotted field
name in quotes.  The following updates the ``street`` field in the
embedded ``address`` document.

.. literalinclude:: includes/example-csharp-update-embedded-field.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-update-embedded-field-results.rst
   :language: csharp



Update Multiple Documents
~~~~~~~~~~~~~~~~~~~~~~~~~

To update multiple documents, use the UpdateManyAsync_ method.  The
following operation updates *all* documents that have
``address.zipcode`` field equal to ``"10016"``, setting the ``borough``
field to ``"Manhattan"`` and the ``lastModified`` field to the current
date.

.. literalinclude:: includes/example-csharp-update-multiple-documents.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-update-multiple-documents-results.rst
   :language: csharp

.. include:: /includes/fact-count-discrepancies.rst

