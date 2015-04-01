Group Documents by a Field and Calculate Count
----------------------------------------------

Use the `group
<http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1pipeline.html#ade56123c1bb038002fb648dce506da08>`_
stage to group by a specified key. In the `group
<http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1pipeline.html#ade56123c1bb038002fb648dce506da08>`_
stage, specify the group by key in the ``_id`` field. `group
<http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1pipeline.html#ade56123c1bb038002fb648dce506da08>`_
accesses fields by the field path, which is the field name prefixed by a
dollar sign ``$``. The `group
<http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1pipeline.html#ade56123c1bb038002fb648dce506da08>`_
stage can use :manual:`accumulators
</meta/aggregation-quick-reference/#group-operators>` to perform
calculations for each group.  The following example groups the documents
in the ``restaurants`` collection by the ``borough`` field and uses the
:group:`$sum` accumulator to count the documents for each group.

.. literalinclude:: includes/example-cpp-group-documents-by-a-field-and-calculate-count.cpp
   :language: cpp







Filter and Group Documents
--------------------------

Use the `match
<http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1pipeline.html#af60dba76fccb47386c0a3e6755635ed4>`_
stage to filter documents. `match
<http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1pipeline.html#af60dba76fccb47386c0a3e6755635ed4>`_
uses the MongoDB :doc:`query syntax </query>`.  The following pipeline
uses `match
<http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1pipeline.html#af60dba76fccb47386c0a3e6755635ed4>`_
to query the ``restaurants`` collection for documents with ``borough``
equal to ``"Queens"`` and ``cuisine`` equal to ``Brazilian``.  Then the
`group
<http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1pipeline.html#ade56123c1bb038002fb648dce506da08>`_
stage groups the matching documents by the ``address.zipcode`` field and
uses the :group:`$sum` accumulator to calculate the count. `group
<http://mongodb.github.io/mongo-cxx-driver/classmongocxx_1_1pipeline.html#ade56123c1bb038002fb648dce506da08>`_
accesses fields by the field path, which is the field name prefixed by a
dollar sign ``$``.

.. literalinclude:: includes/example-cpp-filter-and-group-documents.cpp
   :language: cpp





