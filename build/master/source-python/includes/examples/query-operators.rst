Greater Than Operator (``$gt``)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Query for documents whose ``grades`` array contains an embedded document
with a field ``score`` greater than ``30``.

.. code-block:: python

   cursor = db.restaurants.find({"grades.score": {"$gt": 30}})
   

Iterate the cursor and print the matching documents.

.. code-block:: python

   for document in cursor:
       print(document)
   

The result set includes only the matching documents.



Less Than Operator (``$lt``)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Query for documents whose ``grades`` array contains an embedded document
with a field ``score`` less than ``10``.

.. code-block:: python

   cursor = db.restaurants.find({"grades.score": {"$lt": 10}})
   

Iterate the cursor and print the matching documents.

.. code-block:: python

   for document in cursor:
       print(document)
   

The result set includes only the matching documents.

