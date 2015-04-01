Logical ``AND``
~~~~~~~~~~~~~~~

You can specify a logical conjunction (``AND``) for a list of query
conditions by separating the conditions with a comma in the conditions
document.

.. code-block:: javascript

   db.restaurants.find( { "cuisine": "Italian", "address.zipcode": "10075" } )
   

The result set includes only the documents that matched all specified
criteria.



Logical ``OR``
~~~~~~~~~~~~~~

You can specify a logical disjunction (``OR``) for a list of query
conditions by using the :query:`$or` query operator.

.. code-block:: javascript

   db.restaurants.find(
      { $or: [ { "cuisine": "Italian" }, { "address.zipcode": "10075" } ] }
   )
   

The result set includes only the documents that match either conditions.

