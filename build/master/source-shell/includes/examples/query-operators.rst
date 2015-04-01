Greater Than Operator (``$gt``)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Query for documents whose ``grades`` array contains an embedded document
with a field ``score`` greater than ``30``.

.. code-block:: javascript

   db.restaurants.find( { "grades.score": { $gt: 30 } } )
   

The result set includes only the matching documents.



Less Than Operator (``$lt``)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Query for documents whose ``grades`` array contains an embedded document
with a field ``score`` less than ``10``.

.. code-block:: javascript

   db.restaurants.find( { "grades.score": { $lt: 10 } } )
   

The result set includes only the matching documents.

