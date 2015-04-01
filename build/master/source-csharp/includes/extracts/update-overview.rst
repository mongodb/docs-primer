You can use the UpdateOneAsync_ method, UpdateManyAsync_ method, and ReplaceOneAsync_ method to update documents of a
collection. The methods accept the following parameters:

- a filter document to match the documents to update,

- an update document to specify the modification to perform, and

- an options parameter (optional).

To specify the filter, use the same structure and syntax as
the query conditions. See :doc:`/query` for an introduction to query
conditions.


You cannot update the ``_id`` field.

.. _UpdateOneAsync: http://api.mongodb.org/csharp/2.0.0/html/e612e3f1-6bc0-c182-83c3-ba85f4c7a9c7.htm

.. _UpdateManyAsync: http://api.mongodb.org/csharp/2.0.0/html/5bc85c19-a10a-9790-0f02-77a666a1f63c.htm

.. _ReplaceOneAsync: http://api.mongodb.org/csharp/2.0.0/html/c20e0f41-a73f-fc6e-008c-9879604e48e0.htm

.. _UpdateDefinition: http://api.mongodb.org/csharp/2.0.0/html/0209123e-6bea-03c1-7133-5f268b9a1982.htm

.. _Set: http://api.mongodb.org/csharp/2.0.0/html/8730d08a-f538-b14d-2161-928818218137.htm

.. _CurrentDate: http://api.mongodb.org/csharp/2.0.0/html/2a72af73-503f-ed4f-1a86-da059a431394.htm


