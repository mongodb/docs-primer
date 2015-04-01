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

.. literalinclude:: includes/example-java-group-documents-by-a-field-and-calculate-count.java
   :language: java

Iterate the results and apply a Block to each resulting document:

.. literalinclude:: includes/example-java-group-documents-by-a-field-and-calculate-count-pre1.java
   :language: java

The result set consists of the following documents:

.. literalinclude:: includes/example-java-group-documents-by-a-field-and-calculate-count-results.rst




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

.. literalinclude:: includes/example-java-filter-and-group-documents.java
   :language: java

Iterate the results and apply a Block to each resulting document:

.. literalinclude:: includes/example-java-filter-and-group-documents-pre1.java
   :language: java

The result set consists of the following documents:

.. literalinclude:: includes/example-java-filter-and-group-documents-results.rst




The ``_id`` field contains the distinct ``zipcode`` value, i.e., the
group by key value.
