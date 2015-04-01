After the following update, the modified document will **only** contain
the ``_id`` field, ``name`` field, the ``address`` field. i.e. the
document will *not* contain the ``restaurant_id``, ``cuisine``,
``grades``, and the ``borough`` fields.

.. code-block:: javascript

   db.restaurants.update(
      { "restaurant_id" : "41704620" },
      {
        "name" : "Vella 2",
        "address" : {
                 "coord" : [ -73.9557413, 40.7720266 ],
                 "building" : "1480",
                 "street" : "2 Avenue",
                 "zipcode" : "10075"
        }
      }
   )
   

The update operation returns a :method:`WriteResult` object which
contains the status of the operation.

