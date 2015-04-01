.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">1</div></div>

   Start MongoDB.
   ~~~~~~~~~~~~~~

   Issue the following command to start :program:`mongod`:
   

   .. code-block:: sh
   
      sudo service mongod start
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 1: Start MongoDB.
   ~~~~~~~~~~~~~~~~~~~~~~

   Issue the following command to start :program:`mongod`:
   

   .. code-block:: sh
   
      sudo service mongod start
      

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">2</div></div>

   Verify that MongoDB has started successfully
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Verify that the :program:`mongod` process has started successfully by
   checking the contents of the log file at
   ``/var/log/mongodb/mongod.log``
   for a line reading
   

   .. code-block:: none
   
      [initandlisten] waiting for connections on port <port>
      

   where ``<port>`` is the port configured in ``/etc/mongod.conf``, ``27017`` by default.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 2: Verify that MongoDB has started successfully
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Verify that the :program:`mongod` process has started successfully by
   checking the contents of the log file at
   ``/var/log/mongodb/mongod.log``
   for a line reading
   

   .. code-block:: none
   
      [initandlisten] waiting for connections on port <port>
      

   where ``<port>`` is the port configured in ``/etc/mongod.conf``, ``27017`` by default.
   

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">3</div></div>

   Stop MongoDB.
   ~~~~~~~~~~~~~

   As needed, you can stop the :program:`mongod` process by issuing the
   following command:
   

   .. code-block:: sh
   
      sudo service mongod stop
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 3: Stop MongoDB.
   ~~~~~~~~~~~~~~~~~~~~~

   As needed, you can stop the :program:`mongod` process by issuing the
   following command:
   

   .. code-block:: sh
   
      sudo service mongod stop
      

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">4</div></div>

   Restart MongoDB.
   ~~~~~~~~~~~~~~~~

   Issue the following command to restart :program:`mongod`:
   

   .. code-block:: sh
   
      sudo service mongod restart
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 4: Restart MongoDB.
   ~~~~~~~~~~~~~~~~~~~~~~~~

   Issue the following command to restart :program:`mongod`:
   

   .. code-block:: sh
   
      sudo service mongod restart
      

