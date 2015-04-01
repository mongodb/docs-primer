To return all documents in a collection, call the find_  method
*without* a criteria document. For example, the following operation
queries for all documents in the ``restaurants`` collection.

Define a ``findDocuments`` function as follows:

.. code-block:: javascript

   var findRestaurants = function(db, callback) {
      var cursor =db.collection('restaurants').find( );
      cursor.each(function(err, doc) {
         assert.equal(err, null);
         if (doc != null) {
            console.dir(doc);
         } else {
            callback();
         }
      });
   };
   

Call the ``findDocuments`` function.

.. code-block:: javascript

   MongoClient.connect(url, function(err, db) {
     assert.equal(null, err);
     findRestaurants(db, function() {
         db.close();
     });
   });
   

The result set contains all documents in the ``restaurants`` collection.

