Query by a Top Level Field
~~~~~~~~~~~~~~~~~~~~~~~~~~

The following operation finds documents whose ``borough`` field equals
``"Manhattan"``.

.. literalinclude:: includes/example-csharp-query-top-level-field.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-query-top-level-field-results.rst
   :language: csharp

.. include:: /includes/fact-count-discrepancies.rst





Query by a Field in an Embedded Document
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

To specify a condition on a field within an embedded document, use the
:term:`dot notation`. Dot notation *requires* quotes around the whole
dotted field name.  The following operation specifies an equality
condition on the ``zipcode`` field in the ``address`` embedded document.

.. literalinclude:: includes/example-csharp-query-embedded-document.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-query-embedded-document-results.rst
   :language: csharp

.. include:: /includes/fact-count-discrepancies.rst




For more information on querying on fields within an embedded document,
see :ref:`read-operations-subdocuments`.


Query by a Field in an Array
~~~~~~~~~~~~~~~~~~~~~~~~~~~~

The ``grades`` array contains embedded documents as its elements. To
specify a condition on a field in these documents, use the :term:`dot
notation`. Dot notation *requires* quotes around the whole dotted field
name.  The following queries for documents whose ``grades`` array
contains an embedded document with a field ``grade`` equal to ``"B"``.

.. literalinclude:: includes/example-csharp-query-field-in-array.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-query-field-in-array-results.rst
   :language: csharp

.. include:: /includes/fact-count-discrepancies.rst




For more information on querying on arrays, such as specifying multiple
conditions on array elements, see :ref:`read-operations-arrays` and
:operator:`$elemMatch`.
