Insert a document into a collection named ``restaurants``. The operation
will create the collection if the collection does not currently exist.

.. code-block:: python

   from datetime import datetime
   result = db.restaurants.insert_one(
       {
           "address": {
               "street": "2 Avenue",
               "zipcode": "10075",
               "building": "1480",
               "coord": [-73.9557413, 40.7720266]
           },
           "borough": "Manhattan",
           "cuisine": "Italian",
           "grades": [
               {
                   "date": datetime.strptime("2014-10-01", "%Y-%m-%d"),
                   "grade": "A",
                   "score": 11
               },
               {
                   "date": datetime.strptime("2014-01-16", "%Y-%m-%d"),
                   "grade": "B",
                   "score": 17
               }
           ],
           "name": "Vella",
           "restaurant_id": "41704620"
       }
   )
   

The operation returns an :py:class:`~pymongo.results.InsertOneResult`
object, which includes an attribute
:py:attr:`~pymongo.results.InsertOneResult.inserted_id` that contains
the ``_id`` of the inserted document. Access the
:py:attr:`~pymongo.results.InsertOneResult.inserted_id` attribute:

.. code-block:: python

   
   result.inserted_id
   

The :manual:`ObjectId </reference/object-id>` of your inserted document
will differ from the one shown.

.. code-block:: python

   ObjectId("54c1478ec2341ddf130f62b7")
   

If the document passed to the
:py:meth:`~pymongo.collection.Collection.insert_one` method does not
contain the ``_id`` field, :py:class:`~pymongo.mongo_client.MongoClient`
automatically adds the field to the document and sets the field's value
to a generated :manual:`ObjectId </reference/object-id>`.
