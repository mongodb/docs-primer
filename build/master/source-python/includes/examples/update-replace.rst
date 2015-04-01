After the following update, the modified document will **only** contain
the ``_id`` field, ``name`` field, the ``address`` field. i.e. the
document will *not* contain the ``restaurant_id``, ``cuisine``,
``grades``, and the ``borough`` fields.

.. code-block:: python

   result = db.restaurants.replace_one(
       {"restaurant_id": "41704620"},
       {
           "name": "Vella 2",
           "address": {
               "coord": [-73.9557413, 40.7720266],
               "building": "1480",
               "street": "2 Avenue",
               "zipcode": "10075"
           }
       }
   )
   

The replace_one operation returns an
:py:class:`~pymongo.results.UpdateResult` object which contains the
status of the operation.

To see the number of documents that matched the filter condition, access
the :py:attr:`~pymongo.results.UpdateResult.matched_count` attribute of
the returned :py:class:`~pymongo.results.UpdateResult` object.

.. code-block:: python

   result.matched_count
   

The :py:attr:`~pymongo.results.UpdateResult.matched_count` is:

.. code-block:: python

   1
   

To see the number of documents replaced, access the
:py:attr:`~pymongo.results.UpdateResult.modified_count` attribute of the
returned :py:class:`~pymongo.results.UpdateResult` object.

.. code-block:: python

   result.modified_count
   

The :py:attr:`~pymongo.results.UpdateResult.modified_count` is:

.. code-block:: python

   1
   

