Logical ``AND``
~~~~~~~~~~~~~~~

You can specify a logical conjunction (``AND``) for a list of query
conditions by separating the conditions with a comma in the conditions
document.

Define the ``findRestaurants`` function as follows:

.. code-block:: javascript

   var findRestaurants = function(db, callback) {
      var cursor =db.collection('restaurants').find(
        { "cuisine": "Italian", "address.zipcode": "10075" }
      );
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
   

The result set includes only the documents that matched all specified
criteria.



Logical ``OR``
~~~~~~~~~~~~~~

You can specify a logical disjunction (``OR``) for a list of query
conditions by using the :query:`$or` query operator.

Define the ``findRestaurants`` function as follows:

.. code-block:: javascript

   var findRestaurants = function(db, callback) {
      var cursor =db.collection('restaurants').find( 
          { $or: [ { "cuisine": "Italian" }, { "address.zipcode": "10075" } ] }
      );
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
   

The result set includes only the documents that match either conditions.

