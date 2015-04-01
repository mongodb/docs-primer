Insert a document into a collection named ``restaurants``. The operation
will create the collection if the collection does not currently exist.

.. code-block:: javascript

   db.restaurants.insert(
      {
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
               "date" : ISODate("2014-10-01T00:00:00Z"),
               "grade" : "A",
               "score" : 11
            },
            {
               "date" : ISODate("2014-01-16T00:00:00Z"),
               "grade" : "B",
               "score" : 17
            }
         ],
         "name" : "Vella",
         "restaurant_id" : "41704620"
      }
   )
   

The method returns a :method:`WriteResult` object with the status of the
operation.

.. code-block:: javascript

   WriteResult({ "nInserted" : 1 })
   

If the document passed to the :method:`~db.collection.insert()` method
does not contain the ``_id`` field, the :program:`mongo` shell
automatically adds the field to the document and sets the field's value
to a generated :manual:`ObjectId </reference/object-id>`.
