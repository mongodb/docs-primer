Remove All Documents That Match a Condition
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

The following operation removes all documents that match the specified
condition.

.. code-block:: javascript

   db.restaurants.remove( { "borough": "Manhattan" } )
   

The remove operation returns a :method:`WriteResult` object which
contains the status of the operation. :data:`~WriteResult.nRemoved`
field specifies the number of documents removed.



Use the ``justOne`` Option
~~~~~~~~~~~~~~~~~~~~~~~~~~

By default, the :method:`~db.collection.remove()` method removes all
documents that match the remove condition. Use the ``justOne`` option to
limit the remove operation to only one of the matching documents.

.. code-block:: javascript

   db.restaurants.remove( { "borough": "Queens" }, { justOne: true } )
   

Successful operation should return the following :method:`WriteResult`
object.

.. code-block:: javascript

   WriteResult({ "nRemoved" : 1 })
   

:data:`~WriteResult.nRemoved` field specifies the number of documents
removed, in this case ``1``.


Remove All Documents
~~~~~~~~~~~~~~~~~~~~

To remove all documents from a collection, pass an empty conditions
document ``{}`` to the :method:`~db.collection.remove()` method.

.. code-block:: javascript

   db.restaurants.remove( { } )
   

The remove operation returns a :method:`WriteResult` object which
contains the status of the operation. :data:`~WriteResult.nRemoved`
field specifies the number of documents removed.



Drop a Collection
~~~~~~~~~~~~~~~~~

The remove all operation only removes the documents from the collection.
The collection itself, as well as any indexes for the collection,
remain.  To remove all documents from a collection, it may be more
efficient to drop the entire collection, including the indexes, and then
recreate the collection and rebuild the indexes.  Use the
:method:`~db.collection.drop()` method to drop a collection, including
any indexes.

.. code-block:: javascript

   db.restaurants.drop()
   

Upon successful drop of the collection, the operation returns ``true``.

.. code-block:: javascript

   true

If the collection to drop does not exist, the operation will return
``false``.
