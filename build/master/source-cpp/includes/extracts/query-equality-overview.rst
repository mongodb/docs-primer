The query condition for an equality match on a field has the following
form:

.. code-block:: javascript

   { <field1>: <value1>, <field2>: <value2>, ... }


With the C++ MongoDB driver, use the following code to implement the
conditions document:

.. code-block:: cpp

   document filter;

   filter << field1 << value1 << field2 << value2 ...;


If the ``<field>`` is in an embedded document or an array, use
:term:`dot notation` to access the field.


