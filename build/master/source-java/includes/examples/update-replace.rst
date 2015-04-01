After the following update, the modified document will **only** contain
the ``_id`` field, ``name`` field, the ``address`` field. i.e. the
document will *not* contain the ``restaurant_id``, ``cuisine``,
``grades``, and the ``borough`` fields.

.. literalinclude:: includes/example-java-replace-document.java
   :language: java

.. include:: includes/example-java-replace-document-post.rst

