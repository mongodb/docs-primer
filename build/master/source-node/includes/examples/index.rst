Create a Single-Field Index
---------------------------

Create an ascending index on the ``"cuisine"`` field of the
``restaurants`` collection.

Define an ``indexRestaurants`` function as follows:

.. code-block:: javascript

   var indexRestaurants = function(db, callback) {
      db.collection('restaurants').createIndex( 
         { "cuisine": 1 },
         null,
         function(err, results) {
            console.log(results);
            callback();
         }
      );
   };
   

Call the ``indexRestaurants`` function.

.. code-block:: javascript

   MongoClient.connect(url, function(err, db) {
     assert.equal(null, err);
     indexRestaurants(db, function() {
         db.close();
     });
   });
   

The method returns the name of the created index ``cuisine_1``.



Create a compound index.
------------------------

MongoDB supports :ref:`compound indexes <index-type-compound>` which are
indexes on multiple fields. The order of the fields determine how the
index stores its keys.  For example, the following operation creates a
compound index on the ``"cuisine"`` field and the ``"address.zipcode"``
field. The index orders its entries first by ascending ``"cuisine"``
values, and then, within each ``"cuisine"``, by descending
``"address.zipcode"`` values.

Define an ``indexRestaurants`` function as follows:

.. code-block:: javascript

   var indexRestaurants = function(db, callback) {
      db.collection('restaurants').createIndex( 
         { "cuisine": 1, "address.zipcode": -1 },
         null,
         function(err, results) {
            console.log(results);
            callback();
         }
      );
   };
   

Call the ``indexRestaurants`` function.

.. code-block:: javascript

   MongoClient.connect(url, function(err, db) {
     assert.equal(null, err);
     indexRestaurants(db, function() {
         db.close();
     });
   });
   

The method returns the name of the created index
``cuisine_1_address.zipcode_-1``.

