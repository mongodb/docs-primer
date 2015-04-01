Update Top-Level Fields
~~~~~~~~~~~~~~~~~~~~~~~

The following operation updates the first document with ``name`` equal
to ``"Juni"``, using the :update:`$set` operator to update the
``cuisine`` field and the :update:`$currentDate` operator to update the
``lastModified`` field with the current date.

.. code-block:: python

   result = db.restaurants.update_one(
       {"name": "Juni"},
       {
           "$set": {
               "cuisine": "American (New)"
           },
           "$currentDate": {"lastModified": True}
       }
   )
   

The operation returns a :py:class:`~pymongo.results.UpdateResult` object
that reports the count of documents matched and modified.

To see the number of documents that matched the filter condition, access
the :py:attr:`~pymongo.results.UpdateResult.matched_count` attribute of
the returned :py:class:`~pymongo.results.UpdateResult` object.

.. code-block:: python

   result.matched_count
   

The :py:attr:`~pymongo.results.UpdateResult.matched_count` is :

.. code-block:: python

   1
   

To see the number of documents modified by the update operation, access
the :py:attr:`~pymongo.results.UpdateResult.modified_count` attribute of
the returned :py:class:`~pymongo.results.UpdateResult` object.

.. code-block:: python

   result.modified_count
   

The :py:attr:`~pymongo.results.UpdateResult.modified_count` is:

.. code-block:: python

   1
   



Update an Embedded Field
~~~~~~~~~~~~~~~~~~~~~~~~

To update a field within an embedded document, use the :term:`dot
notation`. When using the dot notation, enclose the whole dotted field
name in quotes.  The following updates the ``street`` field in the
embedded ``address`` document.

.. code-block:: python

   result = db.restaurants.update_one(
       {"restaurant_id": "41156888"},
       {"$set": {"address.street": "East 31st Street"}}
   )
   

The operation returns a :py:class:`~pymongo.results.UpdateResult` object
that reports the count of documents matched and modified.

To see the number of documents that matched the filter condition, access
the :py:attr:`~pymongo.results.UpdateResult.matched_count` attribute of
the returned :py:class:`~pymongo.results.UpdateResult` object.

.. code-block:: python

   result.matched_count
   

The :py:attr:`~pymongo.results.UpdateResult.matched_count` is:

.. code-block:: python

   1
   

To see the number of documents modified by the update operation, access
the :py:attr:`~pymongo.results.UpdateResult.modified_count` attribute of
the returned :py:class:`~pymongo.results.UpdateResult` object.

.. code-block:: python

   result.modified_count
   

The :py:attr:`~pymongo.results.UpdateResult.modified_count` is:

.. code-block:: python

   1
   



Update Multiple Documents
~~~~~~~~~~~~~~~~~~~~~~~~~

The :py:meth:`~pymongo.collection.Collection.update_one` method updates
a single document. To update multiple documents, use the
:py:meth:`~pymongo.collection.Collection.update_many` method.  The
following operation updates *all* documents that have
``address.zipcode`` field equal to ``"10016"``, setting the ``borough``
field to ``"Midtown"`` and the ``lastModified`` field to the current
date.

.. code-block:: python

   result = db.restaurants.update_many(
       {"address.zipcode": "10016", "cuisine": "Other"},
       {
           "$set": {"cuisine": "Category To Be Determined"},
           "$currentDate": {"lastModified": True}
       }
   )
   

The operation returns a :py:class:`~pymongo.results.UpdateResult` object
that reports the count of documents matched and modified.

To see the number of documents that matched the filter condition, access
the :py:attr:`~pymongo.results.UpdateResult.matched_count` attribute of
the returned :py:class:`~pymongo.results.UpdateResult` object.

.. code-block:: python

   result.matched_count
   

The :py:attr:`~pymongo.results.UpdateResult.matched_count` is:

.. code-block:: python

   20
   

To see the number of documents modified by the update operation, access
the :py:attr:`~pymongo.results.UpdateResult.modified_count` attribute of
the returned :py:class:`~pymongo.results.UpdateResult` object.

.. code-block:: python

   result.modified_count
   

The :py:attr:`~pymongo.results.UpdateResult.modified_count` is:

.. code-block:: python

   20
   

