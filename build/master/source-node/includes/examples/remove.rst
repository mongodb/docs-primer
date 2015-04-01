Remove All Documents That Match a Condition
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

The following operation removes all documents that match the specified
condition.

Define a ``removeRestaurants`` function as follows:

.. code-block:: javascript

   var removeRestaurants = function(db, callback) {
      db.collection('restaurants').deleteMany( 
         { "borough": "Manhattan" },
         function(err, results) {
            console.log(results);
            callback();
         }
      );
   };
   

Call the ``removeRestaurants`` function.

.. code-block:: javascript

   MongoClient.connect(url, function(err, db) {
     assert.equal(null, err);
   
     removeRestaurants(db, function() {
         db.close();
     });
   });
   

The operation prints to the console the number of documents removed.



Remove just one document.
~~~~~~~~~~~~~~~~~~~~~~~~~

By default, the deleteOne_ method removes all documents that match the
remove condition. Use the ``justOne`` option to limit the remove
operation to only one of the matching documents.

Define a ``removeRestaurants`` function as follows:

.. code-block:: javascript

   var removeRestaurants = function(db, callback) {
      db.collection('restaurants').deleteOne( 
         { "borough": "Queens" },
         function(err, results) {
            console.log(results);
            callback();
         }
      );
   };
   

Call the ``removeRestaurants`` function.

.. code-block:: javascript

   MongoClient.connect(url, function(err, db) {
     assert.equal(null, err);
   
     removeRestaurants(db, function() {
         db.close();
     });
   });
   

The operation prints to the console the number of documents removed.



Remove All Documents
~~~~~~~~~~~~~~~~~~~~

To remove all documents from a collection, pass an empty conditions
document ``{}`` to the deleteMany_ method.

Define a ``removeRestaurants`` function as follows:

.. code-block:: javascript

   var removeRestaurants = function(db, callback) {
      db.collection('restaurants').deleteMany( {}, function(err, results) {
         console.log(results);
         callback();
      });
   };
   

Call the ``removeRestaurants`` function.

.. code-block:: javascript

   MongoClient.connect(url, function(err, db) {
     assert.equal(null, err);
   
     removeRestaurants(db, function() {
         db.close();
     });
   });
   

The operation prints to the console the number of documents removed.



Drop a Collection
~~~~~~~~~~~~~~~~~

The remove all operation only removes the documents from the collection.
The collection itself, as well as any indexes for the collection,
remain.  To remove all documents from a collection, it may be more
efficient to drop the entire collection, including the indexes, and then
recreate the collection and rebuild the indexes.  Use the drop_ method
to drop a collection, including any indexes.

Define a ``dropRestaurants`` function as follows:

.. code-block:: javascript

   var dropRestaurants = function(db, callback) {
      db.collection('restaurants').drop( function(err, response) {
         console.log(response)
         callback();
      });
   };
   

Call the ``dropRestaurants`` function.

.. code-block:: javascript

   MongoClient.connect(url, function(err, db) {
     assert.equal(null, err);
   
     dropRestaurants(db, function() {
         db.close();
     });
   });
   

Upon successful drop of the collection, the operation prints to the
console ``true``. If the collection to drop does not exist, the
operation prints to the console ``false``.

