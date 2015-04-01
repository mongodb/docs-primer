Create a Single-Field Index
---------------------------

Create an ascending index on the ``"cuisine"`` field of the
``restaurants`` collection.

.. literalinclude:: includes/example-cpp-single-field-index.cpp
   :language: cpp

The second parameter to the method specifies various index options, such
as a unique constraint. In the example, the parameter is an empty
document ``{}`` to specify no additional options.



Create a compound index.
------------------------

MongoDB supports :ref:`compound indexes <index-type-compound>` which are
indexes on multiple fields. The order of the fields determine how the
index stores its keys.  For example, the following operation creates a
compound index on the ``"cuisine"`` field and the ``"address.zipcode"``
field. The index orders its entries first by ascending ``"cuisine"``
values, and then, within each ``"cuisine"``, by descending
``"address.zipcode"`` values.

.. literalinclude:: includes/example-cpp-create-compound-index.cpp
   :language: cpp

The second parameter to the method specifies various index options, such
as a unique constraint. In the example, the parameter is an empty
document ``{}`` to specify no additional options.

