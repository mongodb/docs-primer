.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">1</div></div>

   Set up the MongoDB environment.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   MongoDB requires a :term:`data directory <dbpath>` to store all
   data. MongoDB's default data directory path is ``\data\db``. Create
   this folder using the following commands from a :guilabel:`Command
   Prompt`:
   

   .. code-block:: powershell
   
      md \data\db
      

   You can specify an alternate path for data files using the
   :option:`--dbpath <mongod --dbpath>` option to
   :program:`mongod.exe`, for example:
   

   .. code-block:: powershell
   
      C:\mongodb\bin\mongod.exe --dbpath d:\test\mongodb\data
      

   If your path includes spaces, enclose the entire path in double
   quotes, for example:
   

   .. code-block:: powershell
   
      C:\mongodb\bin\mongod.exe --dbpath "d:\test\mongo db data"
      

   You may also specify the ``dbpath`` in a :manual:`configuration file
   </reference/configuration-options>`.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 1: Set up the MongoDB environment.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   MongoDB requires a :term:`data directory <dbpath>` to store all
   data. MongoDB's default data directory path is ``\data\db``. Create
   this folder using the following commands from a :guilabel:`Command
   Prompt`:
   

   .. code-block:: powershell
   
      md \data\db
      

   You can specify an alternate path for data files using the
   :option:`--dbpath <mongod --dbpath>` option to
   :program:`mongod.exe`, for example:
   

   .. code-block:: powershell
   
      C:\mongodb\bin\mongod.exe --dbpath d:\test\mongodb\data
      

   If your path includes spaces, enclose the entire path in double
   quotes, for example:
   

   .. code-block:: powershell
   
      C:\mongodb\bin\mongod.exe --dbpath "d:\test\mongo db data"
      

   You may also specify the ``dbpath`` in a :manual:`configuration file
   </reference/configuration-options>`.
   

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">2</div></div>

   Start MongoDB.
   ~~~~~~~~~~~~~~

   To start MongoDB, run :program:`mongod.exe`. For example, from the
   :guilabel:`Command Prompt`:
   

   .. code-block:: powershell
   
      C:\mongodb\bin\mongod.exe
      

   This starts the main MongoDB database process. The ``waiting for
   connections`` message in the console output indicates that the
   :program:`mongod.exe` process is running successfully.
   
   Depending on the security level of your system, Windows may pop up a
   :guilabel:`Security Alert` dialog box about blocking "some features" of
   ``C:\mongodb\bin\mongod.exe`` from communicating on
   networks. All users should select ``Private Networks, such as my home or
   work network`` and click ``Allow access``. For additional information on
   security and MongoDB, please see the :manual:`Security Documentation </core/security>`.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 2: Start MongoDB.
   ~~~~~~~~~~~~~~~~~~~~~~

   To start MongoDB, run :program:`mongod.exe`. For example, from the
   :guilabel:`Command Prompt`:
   

   .. code-block:: powershell
   
      C:\mongodb\bin\mongod.exe
      

   This starts the main MongoDB database process. The ``waiting for
   connections`` message in the console output indicates that the
   :program:`mongod.exe` process is running successfully.
   
   Depending on the security level of your system, Windows may pop up a
   :guilabel:`Security Alert` dialog box about blocking "some features" of
   ``C:\mongodb\bin\mongod.exe`` from communicating on
   networks. All users should select ``Private Networks, such as my home or
   work network`` and click ``Allow access``. For additional information on
   security and MongoDB, please see the :manual:`Security Documentation </core/security>`.
   

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">3</div></div>

   Connect to MongoDB.
   ~~~~~~~~~~~~~~~~~~~

   To connect to MongoDB through the :program:`mongo.exe <mongo>` shell,
   open another :guilabel:`Command Prompt`.
   

   .. code-block:: powershell
   
      C:\mongodb\bin\mongo.exe
      

   If you want to develop applications using .NET, see the documentation
   of :ecosystem:`C# and MongoDB </drivers/csharp>` for more information.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 3: Connect to MongoDB.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~

   To connect to MongoDB through the :program:`mongo.exe <mongo>` shell,
   open another :guilabel:`Command Prompt`.
   

   .. code-block:: powershell
   
      C:\mongodb\bin\mongo.exe
      

   If you want to develop applications using .NET, see the documentation
   of :ecosystem:`C# and MongoDB </drivers/csharp>` for more information.
   

