.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">1</div></div>

   Start MongoDB.
   ~~~~~~~~~~~~~~

   You can start the :program:`mongod` process by issuing the following
   command:
   

   .. code-block:: sh
   
      sudo service mongod start
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 1: Start MongoDB.
   ~~~~~~~~~~~~~~~~~~~~~~

   You can start the :program:`mongod` process by issuing the following
   command:
   

   .. code-block:: sh
   
      sudo service mongod start
      

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">2</div></div>

   Verify that MongoDB has started successfully
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   You can verify that the :program:`mongod` process has started
   successfully by checking the contents of the log file at
   ``/var/log/mongodb/mongod.log``
   for a line reading
   

   .. code-block:: none
   
      [initandlisten] waiting for connections on port <port>
      

   where ``<port>`` is the port configured in ``/etc/mongod.conf``, ``27017`` by default.
   
   You can optionally ensure that MongoDB will start following a system
   reboot by issuing the following command:
   

   .. code-block:: sh
   
      sudo chkconfig mongod on
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 2: Verify that MongoDB has started successfully
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   You can verify that the :program:`mongod` process has started
   successfully by checking the contents of the log file at
   ``/var/log/mongodb/mongod.log``
   for a line reading
   

   .. code-block:: none
   
      [initandlisten] waiting for connections on port <port>
      

   where ``<port>`` is the port configured in ``/etc/mongod.conf``, ``27017`` by default.
   
   You can optionally ensure that MongoDB will start following a system
   reboot by issuing the following command:
   

   .. code-block:: sh
   
      sudo chkconfig mongod on
      

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

   You can restart the :program:`mongod` process by issuing the following
   command:
   

   .. code-block:: sh
   
      sudo service mongod restart
      

   You can follow the state of the process for errors or important messages
   by watching the output in the ``/var/log/mongodb/mongod.log`` file.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 4: Restart MongoDB.
   ~~~~~~~~~~~~~~~~~~~~~~~~

   You can restart the :program:`mongod` process by issuing the following
   command:
   

   .. code-block:: sh
   
      sudo service mongod restart
      

   You can follow the state of the process for errors or important messages
   by watching the output in the ``/var/log/mongodb/mongod.log`` file.
   

