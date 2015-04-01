.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">1</div></div>

   Install PyMongo
   ~~~~~~~~~~~~~~~

   Linux/OS X
   ``````````

   You can use ``pip`` to install:
   

   .. code-block:: sh
   
      pip install pymongo
      

   Windows
   ```````

   Use MS Windows installers from `<https://pypi.python.org/pypi/pymongo/>`_.

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 1: Install PyMongo
   ~~~~~~~~~~~~~~~~~~~~~~~

   Linux/OS X
   ``````````

   You can use ``pip`` to install:
   

   .. code-block:: sh
   
      pip install pymongo
      

   Windows
   ```````

   Use MS Windows installers from `<https://pypi.python.org/pypi/pymongo/>`_.

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">2</div></div>

   Import ``pymongo``
   ~~~~~~~~~~~~~~~~~~

   Complete the remainder of this procedure in a Python interactive
   shell, or other Python environment (e.g. script, module, project).
   

   Import ``MongoClient`` from ``pymongo``.
   

   .. code-block:: python
   
      from pymongo import MongoClient
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 2: Import ``pymongo``
   ~~~~~~~~~~~~~~~~~~~~~~~~~~

   Complete the remainder of this procedure in a Python interactive
   shell, or other Python environment (e.g. script, module, project).
   

   Import ``MongoClient`` from ``pymongo``.
   

   .. code-block:: python
   
      from pymongo import MongoClient
      

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">3</div></div>

   Create a Connection
   ~~~~~~~~~~~~~~~~~~~

   Use :py:class:`~pymongo.mongo_client.MongoClient` to create a connection:
   

   .. code-block:: python
   
      client = MongoClient()
      

   If you do not specify any arguments to
   :py:class:`~pymongo.mongo_client.MongoClient`, then
   :py:class:`~pymongo.mongo_client.MongoClient` defaults to the
   MongoDB instance that runs on the ``localhost`` interface on port
   ``27017``.
   

   You can specify a complete :manual:`MongoDB URI </reference/connection-string>` to
   define the connection:
   

   .. code-block:: python
   
      client = MongoClient("mongodb://mongodb0.example.net:27019")
      

   This :py:class:`~pymongo.mongo_client.MongoClient` represents
   the connection to the MongoDB instance that runs on port
   ``27019`` on the ``mongodb.example.net`` system.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 3: Create a Connection
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Use :py:class:`~pymongo.mongo_client.MongoClient` to create a connection:
   

   .. code-block:: python
   
      client = MongoClient()
      

   If you do not specify any arguments to
   :py:class:`~pymongo.mongo_client.MongoClient`, then
   :py:class:`~pymongo.mongo_client.MongoClient` defaults to the
   MongoDB instance that runs on the ``localhost`` interface on port
   ``27017``.
   

   You can specify a complete :manual:`MongoDB URI </reference/connection-string>` to
   define the connection:
   

   .. code-block:: python
   
      client = MongoClient("mongodb://mongodb0.example.net:27019")
      

   This :py:class:`~pymongo.mongo_client.MongoClient` represents
   the connection to the MongoDB instance that runs on port
   ``27019`` on the ``mongodb.example.net`` system.
   

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">4</div></div>

   Access Database Objects
   ~~~~~~~~~~~~~~~~~~~~~~~

   The first fundamental class of objects you will interact with using
   :py:mod:`pymongo` is :py:class:`~pymongo.database.Database` which
   represents the :term:`database` construct in MongoDB. Databases hold
   groups of logically related collections. MongoDB creates new
   databases implicitly upon their first use.
   

   To assign the local variable ``db`` to the database named
   ``primer``, you can use attribute access, as in the following:
   

   .. code-block:: python
   
      db = client.primer
      

   You can also access databases using dictionary-style access,
   which removes Python-specific naming restrictions, as in the
   following:
   

   .. code-block:: python
   
      db = client['primer']
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 4: Access Database Objects
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   The first fundamental class of objects you will interact with using
   :py:mod:`pymongo` is :py:class:`~pymongo.database.Database` which
   represents the :term:`database` construct in MongoDB. Databases hold
   groups of logically related collections. MongoDB creates new
   databases implicitly upon their first use.
   

   To assign the local variable ``db`` to the database named
   ``primer``, you can use attribute access, as in the following:
   

   .. code-block:: python
   
      db = client.primer
      

   You can also access databases using dictionary-style access,
   which removes Python-specific naming restrictions, as in the
   following:
   

   .. code-block:: python
   
      db = client['primer']
      

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">5</div></div>

   Access Collection Objects
   ~~~~~~~~~~~~~~~~~~~~~~~~~

   The second fundamental class of objects you will interact using
   :py:mod:`pymongo` is :py:class:`~pymongo.collection.Collection`,
   which represents the :term:`collection` construct in
   MongoDB. Collections hold groups of related :term:`documents <document>`.
   

   You can access collection objects directly using
   dictionary-style or attribute access from a
   :py:class:`~pymongo.database.Database` object, as in the
   following examples:
   

   .. code-block:: python
   
      db.dataset
      db['dataset']
      

   You may also assign the collection object to a variable for use
   elsewhere, as in the following examples:
   

   .. code-block:: python
   
      coll = db.dataset
      coll = db['dataset']
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 5: Access Collection Objects
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   The second fundamental class of objects you will interact using
   :py:mod:`pymongo` is :py:class:`~pymongo.collection.Collection`,
   which represents the :term:`collection` construct in
   MongoDB. Collections hold groups of related :term:`documents <document>`.
   

   You can access collection objects directly using
   dictionary-style or attribute access from a
   :py:class:`~pymongo.database.Database` object, as in the
   following examples:
   

   .. code-block:: python
   
      db.dataset
      db['dataset']
      

   You may also assign the collection object to a variable for use
   elsewhere, as in the following examples:
   

   .. code-block:: python
   
      coll = db.dataset
      coll = db['dataset']
      

