Group Documents by a Field and Calculate Count
----------------------------------------------

Use the :pipeline:`$group` stage to group by a specified key. In the
:pipeline:`$group`  stage, specify the group by key in the ``_id``
field. :pipeline:`$group` accesses fields by the field path, which is
the field name prefixed by a dollar sign ``$``. The :pipeline:`$group`
stage can use :manual:`accumulators
</meta/aggregation-quick-reference/#group-operators>` to perform
calculations for each group.  The following example groups the documents
in the ``restaurants`` collection by the ``borough`` field and uses the
:group:`$sum` accumulator to count the documents for each group.

.. code-block:: javascript

   db.restaurants.aggregate(
      [
        { $group: { "_id": "$borough", "count": { $sum: 1 } } }
      ]
   );
   

The result set consists of the following documents:

.. code-block:: javascript

   { "_id" : "Staten Island", "count" : 969 }
   { "_id" : "Brooklyn", "count" : 6086 }
   { "_id" : "Manhattan", "count" : 10259 }
   { "_id" : "Queens", "count" : 5656 }
   { "_id" : "Bronx", "count" : 2338 }
   { "_id" : "Missing", "count" : 51 }

The ``_id`` field contains the distinct ``borough`` value, i.e., the
group by key value.


Filter and Group Documents
--------------------------

Use the :pipeline:`$match` stage to filter documents. :pipeline:`$match`
uses the MongoDB :doc:`query syntax </query>`.  The following pipeline
uses :pipeline:`$match` to query the ``restaurants`` collection for
documents with ``borough`` equal to ``"Queens"`` and ``cuisine`` equal
to ``Brazilian``.  Then the :pipeline:`$group` stage groups the matching
documents by the ``address.zipcode`` field and uses the :group:`$sum`
accumulator to calculate the count. :pipeline:`$group` accesses fields
by the field path, which is the field name prefixed by a dollar sign
``$``.

.. code-block:: javascript

   db.restaurants.aggregate(
      [
        { $match: { "borough": "Queens", "cuisine": "Brazilian" } },
        { $group: { "_id": "$address.zipcode" , "count": { $sum: 1 } } }
      ]
   );
   

The result set consists of the following documents:

.. code-block:: javascript

   { "_id" : "11368", "count" : 1 }
   { "_id" : "11106", "count" : 3 }
   { "_id" : "11377", "count" : 1 }
   { "_id" : "11103", "count" : 1 }
   { "_id" : "11101", "count" : 2 }

The ``_id`` field contains the distinct ``zipcode`` value, i.e., the
group by key value.
