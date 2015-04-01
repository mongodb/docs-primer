With the MongoDB Java driver, use the following code to implement
the equalities conditions document:

.. code-block:: java

   new Document( <field>, <value> )

If the ``<field>`` is in an embedded document or an array, use
:term:`dot notation` to access the field.


To help specify the query condition, the Java driver also provides
the Filters_ class. The class contains various static methods to simplify building
the query predicates, including the eq_ method:

.. code-block:: java

   eq(<field>, <value>)

.. _Filters: http://api.mongodb.org/java/3.0/com/mongodb/client/model/Filters.html
.. _eq: http://api.mongodb.org/java/3.0/com/mongodb/client/model/Filters.html#eq-java.lang.String-TItem-


