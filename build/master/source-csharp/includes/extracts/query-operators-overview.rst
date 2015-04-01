
With the C# MongoDB driver, use the methods available in the
FilterDefinitionBuilder_ class to implement the filter document, such
as the Lt_ (less than) and the Gt_ (greater than) methods:


.. code-block:: csharp

   var filterLessThan = Builders<BsonDocument>.Filter.Lt(<field>, <value>);
   var filter = Builders<BsonDocument>.Filter.Gt( <field>, <value>);


.. _FilterDefinitionBuilder_: http://api.mongodb.org/csharp/2.0.0/html/38819066-7427-ca8e-90bb-0d3a3c44d648.htm
.. _Lt: http://api.mongodb.org/csharp/2.0.0/html/1ae4b5a2-a19d-cb77-fc39-a762043c3f1e.htm
.. _Gt: http://api.mongodb.org/csharp/2.0.0/html/1ae4b5a2-a19d-cb77-fc39-a762043c3f1e.htm


