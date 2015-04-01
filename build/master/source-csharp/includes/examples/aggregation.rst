Group Documents by a Field and Calculate Count
----------------------------------------------

Use the `Group
<http://api.mongodb.org/csharp/2.0.0/html/07049bc3-cd52-ecc0-f2ee-da34c69eefee.htm>`_
stage to group by a specified key. In the `Group
<http://api.mongodb.org/csharp/2.0.0/html/07049bc3-cd52-ecc0-f2ee-da34c69eefee.htm>`_
stage, specify the group by key in the ``_id`` field. `Group
<http://api.mongodb.org/csharp/2.0.0/html/07049bc3-cd52-ecc0-f2ee-da34c69eefee.htm>`_
accesses fields by the field path, which is the field name prefixed by a
dollar sign ``$``. The `Group
<http://api.mongodb.org/csharp/2.0.0/html/07049bc3-cd52-ecc0-f2ee-da34c69eefee.htm>`_
stage can use :manual:`accumulators
</meta/aggregation-quick-reference/#group-operators>` to perform
calculations for each group.  The following example groups the documents
in the ``restaurants`` collection by the ``borough`` field and uses the
:group:`$sum` accumulator to count the documents for each group.

.. literalinclude:: includes/example-csharp-group-documents-by-a-field-and-calculate-count.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-group-documents-by-a-field-and-calculate-count-results.rst
   :language: csharp

.. include:: /includes/fact-count-discrepancies.rst





Filter and Group Documents
--------------------------

Use the `Match
<http://api.mongodb.org/csharp/2.0.0/html/345bf4d7-139d-7b56-e192-8552408400fe.htm>`_
stage to filter documents. `Match
<http://api.mongodb.org/csharp/2.0.0/html/345bf4d7-139d-7b56-e192-8552408400fe.htm>`_
uses the MongoDB :doc:`query syntax </query>`.  The following pipeline
uses `Match
<http://api.mongodb.org/csharp/2.0.0/html/345bf4d7-139d-7b56-e192-8552408400fe.htm>`_
to query the ``restaurants`` collection for documents with ``borough``
equal to ``"Queens"`` and ``cuisine`` equal to ``Brazilian``.  Then the
`Group
<http://api.mongodb.org/csharp/2.0.0/html/07049bc3-cd52-ecc0-f2ee-da34c69eefee.htm>`_
stage groups the matching documents by the ``address.zipcode`` field and
uses the :group:`$sum` accumulator to calculate the count. `Group
<http://api.mongodb.org/csharp/2.0.0/html/07049bc3-cd52-ecc0-f2ee-da34c69eefee.htm>`_
accesses fields by the field path, which is the field name prefixed by a
dollar sign ``$``.

.. literalinclude:: includes/example-csharp-filter-and-group-documents.cs
   :language: csharp

.. include:: /includes/fact-csharp-test-w-fluent-assertions.rst

.. literalinclude:: includes/example-csharp-filter-and-group-documents-results.rst
   :language: csharp

.. include:: /includes/fact-count-discrepancies.rst



