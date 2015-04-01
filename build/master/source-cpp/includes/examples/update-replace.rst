After the following update, the modified document will **only** contain
the ``_id`` field, ``name`` field, the ``address`` field. i.e. the
document will *not* contain the ``restaurant_id``, ``cuisine``,
``grades``, and the ``borough`` fields.

.. literalinclude:: includes/example-cpp-replace-document.cpp
   :language: cpp

