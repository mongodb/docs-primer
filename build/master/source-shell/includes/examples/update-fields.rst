Update Top-Level Fields
~~~~~~~~~~~~~~~~~~~~~~~

The following operation updates the first document with ``name`` equal
to ``"Juni"``, using the :update:`$set` operator to update the
``cuisine`` field and the :update:`$currentDate` operator to update the
``lastModified`` field with the current date.

.. code-block:: javascript

   db.restaurants.update(
       { "name" : "Juni" },
       {
         $set: { "cuisine": "American (New)" },
         $currentDate: { "lastModified": true }
       }
   )
   

The update operation returns a :method:`WriteResult` object which
contains the status of the operation.



Update an Embedded Field
~~~~~~~~~~~~~~~~~~~~~~~~

To update a field within an embedded document, use the :term:`dot
notation`. When using the dot notation, enclose the whole dotted field
name in quotes.  The following updates the ``street`` field in the
embedded ``address`` document.

.. code-block:: javascript

   db.restaurants.update(
     { "restaurant_id" : "41156888" },
     { $set: { "address.street": "East 31st Street" } }
   )
   

The update operation returns a :method:`WriteResult` object which
contains the status of the operation.



Update Multiple Documents
~~~~~~~~~~~~~~~~~~~~~~~~~

By default, the :method:`~db.collection.update()` method updates a
single document. To update multiple documents, use the ``multi`` option
in the :method:`~db.collection.update()` method.  The following
operation updates *all* documents that have ``address.zipcode`` field
equal to ``"10016"`` and ``cuisine`` field equal to ``"Other"``, setting
the ``cuisine`` field to ``"Category To Be Determined"`` and the
``lastModified`` field to the current date.

.. code-block:: javascript

   db.restaurants.update(
     { "address.zipcode": "10016", cuisine: "Other" },
     {
       $set: { cuisine: "Category To Be Determined" },
       $currentDate: { "lastModified": true }
     },
     { multi: true}
   )
   

The update operation returns a :method:`WriteResult` object which
contains the status of the operation.

