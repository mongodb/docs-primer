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

.. code-block:: python

   cursor = db.restaurants.aggregate(
       [
           {"$group": {"_id": "$borough", "count": {"$sum": 1}}}
       ]
   )
   

Iterate the cursor and print the matching documents.

.. code-block:: python

   for document in cursor:
       print(document)
   

The result set consists of the following documents:

.. code-block:: python

   {u'count': 969, u'_id': u'Staten Island'}
   {u'count': 6086, u'_id': u'Brooklyn'}
   {u'count': 10259, u'_id': u'Manhattan'}
   {u'count': 5656, u'_id': u'Queens'}
   {u'count': 2338, u'_id': u'Bronx'}
   {u'count': 51, u'_id': u'Missing'}

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

.. code-block:: python

   cursor = db.restaurants.aggregate(
       [
           {"$match": {"borough": "Queens", "cuisine": "Brazilian"}},
           {"$group": {"_id": "$address.zipcode", "count": {"$sum": 1}}}
       ]
   )
   

Iterate the cursor and print the matching documents.

.. code-block:: python

   for document in cursor:
       print(document)
   

The result set consists of the following documents:

.. code-block:: python

   {u'count': 1, u'_id': u'11368'}
   {u'count': 3, u'_id': u'11106'}
   {u'count': 1, u'_id': u'11377'}
   {u'count': 1, u'_id': u'11103'}
   {u'count': 2, u'_id': u'11101'}

The ``_id`` field contains the distinct ``zipcode`` value, i.e., the
group by key value.
