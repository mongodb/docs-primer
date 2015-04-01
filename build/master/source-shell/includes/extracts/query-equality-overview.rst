The query condition for an equality match on a field has the following
form:

.. code-block:: javascript

   { <field1>: <value1>, <field2>: <value2>, ... }


If the ``<field>`` is a top-level field and not a field in an embedded
document or an array, you can either enclose the field name in quotes
or omit the quotes.

If the ``<field>`` is in an embedded document or an array, use
:term:`dot notation` to access the field. With dot notation, you must
enclose the dotted name in quotes.


