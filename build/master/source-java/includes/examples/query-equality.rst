Query by a Top Level Field
~~~~~~~~~~~~~~~~~~~~~~~~~~

The following operation finds documents whose ``borough`` field equals
``"Manhattan"``.

.. literalinclude:: includes/example-java-query-top-level-field.java
   :language: java

.. include:: includes/example-java-query-top-level-field-pre1.rst

.. literalinclude:: includes/example-java-query-top-level-field-pre1.java
   :language: java

.. include:: includes/fact-java-filters-helpers.rst

.. literalinclude:: includes/example-java-query-top-level-field-pre2.java
   :language: java





Query by a Field in an Embedded Document
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

To specify a condition on a field within an embedded document, use the
:term:`dot notation`. Dot notation *requires* quotes around the whole
dotted field name.  The following operation specifies an equality
condition on the ``zipcode`` field in the ``address`` embedded document.

.. literalinclude:: includes/example-java-query-embedded-document.java
   :language: java

.. include:: includes/example-java-query-embedded-document-pre1.rst

.. literalinclude:: includes/example-java-query-embedded-document-pre1.java
   :language: java

.. include:: includes/fact-java-filters-helpers.rst

.. literalinclude:: includes/example-java-query-embedded-document-pre2.java
   :language: java




For more information on querying on fields within an embedded document,
see :ref:`read-operations-subdocuments`.


Query by a Field in an Array
~~~~~~~~~~~~~~~~~~~~~~~~~~~~

The ``grades`` array contains embedded documents as its elements. To
specify a condition on a field in these documents, use the :term:`dot
notation`. Dot notation *requires* quotes around the whole dotted field
name.  The following queries for documents whose ``grades`` array
contains an embedded document with a field ``grade`` equal to ``"B"``.

.. literalinclude:: includes/example-java-query-field-in-array.java
   :language: java

.. include:: includes/example-java-query-field-in-array-pre1.rst

.. literalinclude:: includes/example-java-query-field-in-array-pre1.java
   :language: java

.. include:: includes/fact-java-filters-helpers.rst

.. literalinclude:: includes/example-java-query-field-in-array-pre2.java
   :language: java




For more information on querying on arrays, such as specifying multiple
conditions on array elements, see :ref:`read-operations-arrays` and
:operator:`$elemMatch`.
