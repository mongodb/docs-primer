Create a Single-Field Index
---------------------------

Create an ascending index on the ``"cuisine"`` field of the
``restaurants`` collection.

.. literalinclude:: includes/example-csharp-single-field-index.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-single-field-index-results.rst
   :language: csharp



Create a compound index.
------------------------

MongoDB supports :ref:`compound indexes <index-type-compound>` which are
indexes on multiple fields. The order of the fields determine how the
index stores its keys.  For example, the following operation creates a
compound index on the ``"cuisine"`` field and the ``"address.zipcode"``
field. The index orders its entries first by ascending ``"cuisine"``
values, and then, within each ``"cuisine"``, by descending
``"address.zipcode"`` values.

.. literalinclude:: includes/example-csharp-create-compound-index.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-create-compound-index-results.rst
   :language: csharp

