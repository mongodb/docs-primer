To specify an order for the result set, append the
:py:meth:`~pymongo.cursor.Cursor.sort()` method to the query. Pass to
:py:meth:`~pymongo.cursor.Cursor.sort()` method a document which
contains the field(s) to sort by and the corresponding sort type, e.g.
``pymongo.ASCENDING`` for ascending and ``pymongo.DESCENDING`` for
descending.

To sort by multiple keys, pass a list of keys and sort type pairs. For
example, the following operation returns all documents in the
``restaurants`` collection, sorted first by the ``borough`` field in
ascending order, and then, within each borough, by the
``"address.zipcode"`` field in ascending order:

.. code-block:: python

   import pymongo
   cursor = db.restaurants.find().sort([
       ("borough", pymongo.ASCENDING),
       ("address.zipcode", pymongo.DESCENDING)
   ])
   

Iterate the cursor and print the matching documents.

.. code-block:: python

   for document in cursor:
       print(document)
   

The operation returns the results sorted in the specified order.

