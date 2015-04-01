To specify an order for the result set, append the
:method:`~cursor.sort()` method to the query. Pass to
:method:`~cursor.sort()` method a document which contains the field(s)
to sort by and the corresponding sort type, e.g. ``1`` for ascending and
``-1`` for descending.

For example, the following operation returns all documents in the
``restaurants`` collection, sorted first by the ``borough`` field in
ascending order, and then, within each borough, by the
``"address.zipcode"`` field in ascending order:

.. code-block:: javascript

   db.restaurants.find().sort( { "borough": 1, "address.zipcode": 1 } )
   

The operation returns the results sorted in the specified order.

