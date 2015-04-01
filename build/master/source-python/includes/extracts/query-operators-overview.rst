MongoDB provides operators to specify query conditions, such as
:manual:`comparison operators </reference/operators/query-comparison>`.
Although there are some exceptions, such as the :query:`$or` and
:query:`$and` conditional operators, query conditions using operators
generally have the following form:


.. code-block:: javascript

   { <field1>: { <operator1>: <value1> } }

For a complete list of the operators, see :manual:`query operators
</reference/operator/query>`.


