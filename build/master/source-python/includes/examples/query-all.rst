To return all documents in a collection, call the
:py:meth:`~pymongo.collection.Collection.find()`  method *without* a
criteria document. For example, the following operation queries for all
documents in the ``restaurants`` collection.

.. code-block:: python

   cursor = db.restaurants.find()
   

Iterate the cursor and print the documents.

.. code-block:: python

   for document in cursor:
       print(document)
   

The result set contains all documents in the ``restaurants`` collection.

