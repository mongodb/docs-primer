MongoDB provides operators to specify query conditions, such as
:manual:`comparison operators </reference/operators/query-comparison>`.
Although there are some exceptions, such as the :query:`$or` and
:query:`$and` conditional operators, query conditions using operators
generally have the following form:


.. code-block:: none

   document filter;
   filter << field1 << open_document << operator1 << value1 << close_document;


