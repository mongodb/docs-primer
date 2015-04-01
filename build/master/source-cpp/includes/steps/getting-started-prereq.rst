.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">1</div></div>

   Retrieve the ``restaurants`` data.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Retrieve the dataset from
   `<https://github.com/mongodb/docs-assets/blob/primer-dataset/dataset.json>`_
   and save to a file named ``primer-dataset.json``.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 1: Retrieve the ``restaurants`` data.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Retrieve the dataset from
   `<https://github.com/mongodb/docs-assets/blob/primer-dataset/dataset.json>`_
   and save to a file named ``primer-dataset.json``.
   

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">2</div></div>

   Import data into the collection.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   In the system shell or command prompt, use :program:`mongoimport` to
   insert the documents into the ``restaurants`` collection in the
   ``test`` database. If the collection already exists in the ``test``
   database, the operation will **drop** the ``restaurants`` collection
   first.
   

   .. code-block:: javascript
   
      mongoimport --db test --collection restaurants --drop --file primer-dataset.json
      

   The :program:`mongoimport` connects to a :program:`mongod` instance
   running on localhost on port number ``27017``.
   
   To import data into a :program:`mongod` instance running on a
   different host or port, specify the hostname or port by including the
   ``--host`` and the ``--port`` options in your :program:`mongoimport`
   command.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 2: Import data into the collection.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   In the system shell or command prompt, use :program:`mongoimport` to
   insert the documents into the ``restaurants`` collection in the
   ``test`` database. If the collection already exists in the ``test``
   database, the operation will **drop** the ``restaurants`` collection
   first.
   

   .. code-block:: javascript
   
      mongoimport --db test --collection restaurants --drop --file primer-dataset.json
      

   The :program:`mongoimport` connects to a :program:`mongod` instance
   running on localhost on port number ``27017``.
   
   To import data into a :program:`mongod` instance running on a
   different host or port, specify the hostname or port by including the
   ``--host`` and the ``--port`` options in your :program:`mongoimport`
   command.
   

