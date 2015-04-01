.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">1</div></div>

   Open an Administrator command prompt.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Windows 7 / Vista / Server 2008 (and R2)
   ````````````````````````````````````````

   Press ``Win + R``, then type ``cmd``, then press ``Ctrl + Shift + Enter``.
   

   Windows 8
   `````````

   Press ``Win + X``, then press ``A``.
   

   Execute the remaining steps from the Administrator command prompt.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 1: Open an Administrator command prompt.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Windows 7 / Vista / Server 2008 (and R2)
   ````````````````````````````````````````

   Press ``Win + R``, then type ``cmd``, then press ``Ctrl + Shift + Enter``.
   

   Windows 8
   `````````

   Press ``Win + X``, then press ``A``.
   

   Execute the remaining steps from the Administrator command prompt.
   

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">2</div></div>

   Create directories.
   ~~~~~~~~~~~~~~~~~~~

   Create directories for your database and log files:
   

   .. code-block:: powershell
   
      mkdir c:\data\db
      mkdir c:\data\log
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 2: Create directories.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Create directories for your database and log files:
   

   .. code-block:: powershell
   
      mkdir c:\data\db
      mkdir c:\data\log
      

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">3</div></div>

   Create a configuration file.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Create a :manual:`configuration file </reference/configuration-options>`. This file can include any
   of the :manual:`configuration options </reference/configuration-options>` for :program:`mongod`, but
   **must** include a valid setting for :setting:`logpath`:
   

   The following creates a configuration file, specifying both the
   :setting:`logpath` and the :setting:`dbpath` settings in the
   configuration file:
   

   .. code-block:: powershell
   
      echo logpath=c:\data\log\mongod.log> "C:\mongodb\mongod.cfg"
      echo dbpath=c:\data\db>> "C:\mongodb\mongod.cfg"
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 3: Create a configuration file.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Create a :manual:`configuration file </reference/configuration-options>`. This file can include any
   of the :manual:`configuration options </reference/configuration-options>` for :program:`mongod`, but
   **must** include a valid setting for :setting:`logpath`:
   

   The following creates a configuration file, specifying both the
   :setting:`logpath` and the :setting:`dbpath` settings in the
   configuration file:
   

   .. code-block:: powershell
   
      echo logpath=c:\data\log\mongod.log> "C:\mongodb\mongod.cfg"
      echo dbpath=c:\data\db>> "C:\mongodb\mongod.cfg"
      

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">4</div></div>

   Create the MongoDB service.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Create the MongoDB service.

   .. code-block:: powershell
   
      sc.exe create MongoDB binPath= "\"C:\mongodb\bin\mongod.exe\" --service --config=\"C:\mongodb\mongod.cfg\"" DisplayName= "MongoDB" start= "auto"
      

   ``sc.exe`` requires a space between "=" and the configuration values
   (eg "binPath= "), and a "\\" to escape double quotes.
   

   If successfully created, the following log message will display:

   .. code-block:: powershell
   
      [SC] CreateService SUCCESS
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 4: Create the MongoDB service.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Create the MongoDB service.

   .. code-block:: powershell
   
      sc.exe create MongoDB binPath= "\"C:\mongodb\bin\mongod.exe\" --service --config=\"C:\mongodb\mongod.cfg\"" DisplayName= "MongoDB" start= "auto"
      

   ``sc.exe`` requires a space between "=" and the configuration values
   (eg "binPath= "), and a "\\" to escape double quotes.
   

   If successfully created, the following log message will display:

   .. code-block:: powershell
   
      [SC] CreateService SUCCESS
      

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">5</div></div>

   Start the MongoDB service.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~

   .. code-block:: powershell
   
      net start MongoDB
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 5: Start the MongoDB service.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   .. code-block:: powershell
   
      net start MongoDB
      

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">6</div></div>

   Stop or remove the MongoDB service as needed.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   To stop the MongoDB service, use the following command:

   .. code-block:: powershell
   
      net stop MongoDB
      

   To remove the MongoDB service, first stop the service and then
   run the following command:
   

   .. code-block:: powershell
   
      sc.exe delete MongoDB
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 6: Stop or remove the MongoDB service as needed.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   To stop the MongoDB service, use the following command:

   .. code-block:: powershell
   
      net stop MongoDB
      

   To remove the MongoDB service, first stop the service and then
   run the following command:
   

   .. code-block:: powershell
   
      sc.exe delete MongoDB
      

