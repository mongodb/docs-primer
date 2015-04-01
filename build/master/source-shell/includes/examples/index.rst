Create a Single-Field Index
---------------------------

Create an ascending index on the ``"cuisine"`` field of the
``restaurants`` collection.

.. code-block:: javascript

   db.restaurants.createIndex( { "cuisine": 1 } )
   

The method returns a document with the status of the operation.

.. code-block:: javascript

   {
     "createdCollectionAutomatically" : false,
     "numIndexesBefore" : 1,
     "numIndexesAfter" : 2,
     "ok" : 1
   }
   

Upon successful index creation, the ``"numIndexesAfter"`` value is one
greater than the ``"numIndexesBefore"`` value.


Create a compound index.
------------------------

MongoDB supports :ref:`compound indexes <index-type-compound>` which are
indexes on multiple fields. The order of the fields determine how the
index stores its keys.  For example, the following operation creates a
compound index on the ``"cuisine"`` field and the ``"address.zipcode"``
field. The index orders its entries first by ascending ``"cuisine"``
values, and then, within each ``"cuisine"``, by descending
``"address.zipcode"`` values.

.. code-block:: javascript

   db.restaurants.createIndex( { "cuisine": 1, "address.zipcode": -1 } )
   

The method returns a document with the status of the operation.

.. code-block:: javascript

   {
      "createdCollectionAutomatically" : false,
      "numIndexesBefore" : 2,
      "numIndexesAfter" : 3,
      "ok" : 1
   }
   

Upon successful index creation, the ``"numIndexesAfter"`` value is one
greater than the ``"numIndexesBefore"`` value.
