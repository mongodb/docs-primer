With the C# MongoDB driver, you can use the FilterDefinitionBuilder_ to
implement the filter document.  For example, FilterDefinitionBuilder_ provides
an Eq_ method to implement a filter document that specifies an equality
condition:

.. code-block:: csharp

   var filter = Builders<BsonDocument>.Filter.Eq(<field>, <value>);


If the ``<field>`` is in an embedded document or an array, use
:term:`dot notation` to access the field.

.. _FilterDefinitionBuilder: http://api.mongodb.org/csharp/2.0.0/html/38819066-7427-ca8e-90bb-0d3a3c44d648.htm
.. _Eq: http://api.mongodb.org/csharp/2.0.0/html/30851536-b5db-bee4-5452-b83922524fb0.htm


