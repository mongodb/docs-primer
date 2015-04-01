Insert a document into a collection named ``restaurants``. The operation
will create the collection if the collection does not currently exist.

Defines a function ``insertDocument``:

.. code-block:: javascript

   var insertDocument = function(db, callback) {
      db.collection('restaurants').insertOne( {
         "address" : {
            "street" : "2 Avenue",
            "zipcode" : "10075",
            "building" : "1480",
            "coord" : [ -73.9557413, 40.7720266 ],
         },
         "borough" : "Manhattan",
         "cuisine" : "Italian",
         "grades" : [
            {
               "date" : new Date("2014-10-01T00:00:00Z"),
               "grade" : "A",
               "score" : 11
            },
            {
               "date" : new Date("2014-01-16T00:00:00Z"),
               "grade" : "B",
               "score" : 17
            }
         ],
         "name" : "Vella",
         "restaurant_id" : "41704620"
      }, function(err, result) {
       assert.equal(err, null);
       console.log("Inserted a document into the restaurants collection.");
       callback(result);
     });
   };
   

Call the ``insertDocument`` function.

.. code-block:: javascript

   MongoClient.connect(url, function(err, db) {
     assert.equal(null, err);
     insertDocument(db, function() {
         db.close();
     });
   });
   

A successful insert should print out the following line:

.. code-block:: sh

   Inserted a document into the restaurants collection.


If the document passed to the insertOne_ method does not contain the
``_id`` field, the driver automatically adds the field to the document
and sets the field's value to a generated :manual:`ObjectId
</reference/object-id>`.
