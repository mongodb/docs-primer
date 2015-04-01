Query by a Top Level Field
~~~~~~~~~~~~~~~~~~~~~~~~~~

The following operation finds documents whose ``borough`` field equals
``"Manhattan"``.

.. code-block:: python

   cursor = db.restaurants.find({"borough": "Manhattan"})
   

Iterate the cursor and print the matching documents.

.. code-block:: python

   for document in cursor:
       print(document)
   

The result set includes only the matching documents.



Query by a Field in an Embedded Document
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

To specify a condition on a field within an embedded document, use the
:term:`dot notation`. Dot notation *requires* quotes around the whole
dotted field name.  The following operation specifies an equality
condition on the ``zipcode`` field in the ``address`` embedded document.

.. code-block:: python

   cursor = db.restaurants.find({"address.zipcode": "10075"})
   

Iterate the cursor and print the matching documents.

.. code-block:: python

   for document in cursor:
       print(document)
   

The result set includes only the matching documents.


For more information on querying on fields within an embedded document,
see :ref:`read-operations-subdocuments`.


Query by a Field in an Array
~~~~~~~~~~~~~~~~~~~~~~~~~~~~

The ``grades`` array contains embedded documents as its elements. To
specify a condition on a field in these documents, use the :term:`dot
notation`. Dot notation *requires* quotes around the whole dotted field
name.  The following queries for documents whose ``grades`` array
contains an embedded document with a field ``grade`` equal to ``"B"``.

.. code-block:: python

   cursor = db.restaurants.find({"grades.grade": "B"})
   

Iterate the cursor and print the matching documents.

.. code-block:: python

   for document in cursor:
       print(document)
   

The result set includes only the matching documents.


For more information on querying on arrays, such as specifying multiple
conditions on array elements, see :ref:`read-operations-arrays` and
:operator:`$elemMatch`.
