To change a field value, MongoDB provides :manual:`update operators
</reference/operator/update>`, such as :update:`$set` to modify
values. Some update operators, such as :update:`$set`, will create
the field if the field does not exist. See the individual
:manual:`update operators </reference/operator/update>` reference.


In the C# driver, the UpdateDefinition_ document defines the update
operations to perform. Use the UpdateDefinitionBuilder_ to build the
UpdateDefinition_.

.. _UpdateDefinitionBuilder: http://api.mongodb.org/csharp/2.0.0/html/7f74e7a2-746f-84b0-488e-936decac75af.htm


