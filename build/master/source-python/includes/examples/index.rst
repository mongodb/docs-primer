Create a Single-Field Index
---------------------------

Create an ascending index on the ``"cuisine"`` field of the
``restaurants`` collection.

.. code-block:: python

   import pymongo
   db.restaurants.create_index([("cuisine", pymongo.ASCENDING)])
   

The method returns the name of the created index.

.. code-block:: python

   "u'cuisine_1'"
   


Create a compound index.
------------------------

MongoDB supports :ref:`compound indexes <index-type-compound>` which are
indexes on multiple fields. The order of the fields determine how the
index stores its keys.  For example, the following operation creates a
compound index on the ``"cuisine"`` field and the ``"address.zipcode"``
field. The index orders its entries first by ascending ``"cuisine"``
values, and then, within each ``"cuisine"``, by descending
``"address.zipcode"`` values.

.. code-block:: python

   import pymongo
   db.restaurants.create_index([
       ("cuisine", pymongo.ASCENDING),
       ("address.zipcode", pymongo.DESCENDING)
   ])
   

The method returns the name of the created index.

.. code-block:: python

   "u'cuisine_1_address.zipcode_-1'"
   
