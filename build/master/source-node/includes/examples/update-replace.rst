After the following update, the modified document will **only** contain
the ``_id`` field, ``name`` field, the ``address`` field. i.e. the
document will *not* contain the ``restaurant_id``, ``cuisine``,
``grades``, and the ``borough`` fields.

Define an ``updateRestaurants`` function as follows:

.. code-block:: javascript

   var updateRestaurants = function(db, callback) {
      db.collection('restaurants').replaceOne(
         { "restaurant_id" : "41704620" },
         {
           "name" : "Vella 2",
           "address" : {
              "coord" : [ -73.9557413, 40.7720266 ],
              "building" : "1480",
              "street" : "2 Avenue",
              "zipcode" : "10075"
           }
         },
         function(err, results) {
           console.log(results);
           callback();
      });
   };
   

Call the ``updateRestaurants`` function.

.. code-block:: javascript

   MongoClient.connect(url, function(err, db) {
     assert.equal(null, err);
   
     updateRestaurants(db, function() {
         db.close();
     });
   });
   

The replaceOne_ returns the number of documents updated.

