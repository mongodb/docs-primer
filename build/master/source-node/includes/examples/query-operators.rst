Greater Than Operator (``$gt``)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Query for documents whose ``grades`` array contains an embedded document
with a field ``score`` greater than ``30``.

Define a ``findRestaurants`` function as follows:

.. code-block:: javascript

   var findRestaurants = function(db, callback) {
      var cursor =db.collection('restaurants').find( { "grades.score": { $gt: 30 } } );
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
   

The result set includes only the matching documents.



Less Than Operator (``$lt``)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Query for documents whose ``grades`` array contains an embedded document
with a field ``score`` less than ``10``.

Define a ``findRestaurants`` function as follows:

.. code-block:: javascript

   var findRestaurants = function(db, callback) {
      var cursor =db.collection('restaurants').find( { "grades.score": { $lt: 10 } } );
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
   

The result set includes only the matching documents.

