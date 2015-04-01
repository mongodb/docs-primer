To return all documents in a collection, call the
:method:`~db.collection.find()`  method *without* a criteria document.
For example, the following operation queries for all documents in the
``restaurants`` collection.

.. code-block:: javascript

   db.restaurants.find()
   

The result set contains all documents in the ``restaurants`` collection.

