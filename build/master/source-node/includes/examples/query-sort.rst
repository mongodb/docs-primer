To specify an order for the result set, append the `sort()
<http://mongodb.github.io/node-mongodb-native/2.0/api/Cursor.html#sort>`_
method to the query. Pass to  `sort()
<http://mongodb.github.io/node-mongodb-native/2.0/api/Cursor.html#sort>`_
method a document which contains the field(s) to sort by and the
corresponding sort type, e.g. ``1`` for ascending and ``-1`` for
descending.

Define a ``findRestaurants`` function to retrieve all documents in the
``restaurants`` collection, sorted first by the ``borough`` field in
ascending order, and then, within each borough, by the
``"address.zipcode"`` field in ascending order.

.. code-block:: javascript

   var findRestaurants = function(db, callback) {
      var cursor =db.collection('restaurants').find().sort( { "borough": 1, "address.zipcode": 1 } );
      cursor.each(function(err, doc) {
         assert.equal(err, null);
         if (doc != null) {
            console.dir(doc);
         } else {
            callback();
         }
      });
   };
   

Call the ``findRestaurants`` function.

.. code-block:: javascript

   MongoClient.connect(url, function(err, db) {
     assert.equal(null, err);
   
     findRestaurants(db, function() {
         db.close();
     });
   });
   

The operation returns the results sorted in the specified order.

