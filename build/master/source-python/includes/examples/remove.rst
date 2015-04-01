Remove All Documents That Match a Condition
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

The following operation removes all documents that match the specified
condition.

.. code-block:: python

   result = db.restaurants.delete_many({"borough": "Manhattan"})
   

The operation returns a :py:class:`~pymongo.results.DeleteResult` which
reports the number of documents removed.

To see the number of documents deleted, access the
:py:attr:`~pymongo.results.DeleteResult.deleted_count` attribute of the
returned :py:class:`~pymongo.results.DeleteResult` object.

.. code-block:: python

   result.deleted_count
   

The :py:attr:`~pymongo.results.DeleteResult.deleted_count` is:

.. code-block:: python

   10259
   

If you have inserted or updated documents, such as specified in the
Insert Data or Update Data sections of the Getting Started guide, your
count may differ.



Remove All Documents
~~~~~~~~~~~~~~~~~~~~

To remove all documents from a collection, pass an empty conditions
document ``{}`` to the
:py:meth:`~pymongo.collection.Collection.delete_many` method.

.. code-block:: python

   result = db.restaurants.delete_many({})
   

The operation returns a :py:class:`~pymongo.results.DeleteResult` which
reports the number of documents removed.

To see the number of documents deleted, access the
:py:attr:`~pymongo.results.DeleteResult.deleted_count` attribute of the
returned :py:class:`~pymongo.results.DeleteResult` object.

.. code-block:: python

   result.deleted_count
   

The :py:attr:`~pymongo.results.DeleteResult.deleted_count` is:

.. code-block:: python

   15100
   

If you have inserted or updated documents, such as specified in the
Insert Data or Update Data sections of the Getting Started guide, your
count may differ.



Drop a Collection
~~~~~~~~~~~~~~~~~

The remove all operation only removes the documents from the collection.
The collection itself, as well as any indexes for the collection,
remain.  To remove all documents from a collection, it may be more
efficient to drop the entire collection, including the indexes, and then
recreate the collection and rebuild the indexes.  Use the
:py:meth:`~pymongo.collection.Collection.drop` method to drop a
collection, including any indexes.

.. code-block:: python

   db.restaurants.drop()
   

