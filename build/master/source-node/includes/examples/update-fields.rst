Update Top-Level Fields
~~~~~~~~~~~~~~~~~~~~~~~

The following operation updates the first document with ``name`` equal
to ``"Juni"``, using the :update:`$set` operator to update the
``cuisine`` field and the :update:`$currentDate` operator to update the
``lastModified`` field with the current date.

Define an ``updateRestaurants`` function as follows:

.. code-block:: javascript

   var updateRestaurants = function(db, callback) {
      db.collection('restaurants').updateOne(
         { "name" : "Juni" },
         {
           $set: { "cuisine": "American (New)" },
           $currentDate: { "lastModified": true }
         }, function(err, results) {
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
   

The updateOne_ returns the number of documents updated.



Update an Embedded Field
~~~~~~~~~~~~~~~~~~~~~~~~

To update a field within an embedded document, use the :term:`dot
notation`. When using the dot notation, enclose the whole dotted field
name in quotes.  The following updates the ``street`` field in the
embedded ``address`` document.

Define an ``updateRestaurants`` function as follows:

.. code-block:: javascript

   var updateRestaurants = function(db, callback) {
      db.collection('restaurants').updateOne(
         { "restaurant_id" : "41156888" },
         { $set: { "address.street": "East 31st Street" } },
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
   

The updateOne_ returns the number of documents updated.



Update Multiple Documents
~~~~~~~~~~~~~~~~~~~~~~~~~

To update multiple documents, use the updateMany_ method.  The following
operation updates *all* documents that have ``address.zipcode`` field
equal to ``"10016"`` and ``cuisine`` field equal to ``"Other"``, setting
the ``cuisine`` field to ``"Category To Be Determined"`` and the
``lastModified`` field to the current date.

Define an ``updateRestaurants`` function as follows:

.. code-block:: javascript

   var updateRestaurants = function(db, callback) {
      db.collection('restaurants').updateMany(
         { "address.zipcode": "10016", cuisine: "Other" },
         {
           $set: { cuisine: "Category To Be Determined" },
           $currentDate: { "lastModified": true }
         }
         ,
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
   

The updateMany_ returns the number of documents updated.

