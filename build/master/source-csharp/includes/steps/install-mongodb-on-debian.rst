.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">1</div></div>

   Import the public key used by the package management system.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Issue the following command to add the `MongoDB public GPG Key
   <http://docs.mongodb.org/10gen-gpg-key.asc>`_ to the system key ring.
   

   .. code-block:: sh
   
      sudo apt-key adv --keyserver keyserver.ubuntu.com --recv 7F0CEB10
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 1: Import the public key used by the package management system.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Issue the following command to add the `MongoDB public GPG Key
   <http://docs.mongodb.org/10gen-gpg-key.asc>`_ to the system key ring.
   

   .. code-block:: sh
   
      sudo apt-key adv --keyserver keyserver.ubuntu.com --recv 7F0CEB10
      

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">2</div></div>

   Create a ``/etc/apt/sources.list.d/mongodb-org-3.0.list`` file for MongoDB.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Create the list file using the following command:
   

   .. code-block:: sh
   
      echo "deb http://repo.mongodb.org/apt/debian "$(lsb_release -sc)"/mongodb-org/3.0 main" | sudo tee /etc/apt/sources.list.d/mongodb-org-3.0.list
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 2: Create a ``/etc/apt/sources.list.d/mongodb-org-3.0.list`` file for MongoDB.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Create the list file using the following command:
   

   .. code-block:: sh
   
      echo "deb http://repo.mongodb.org/apt/debian "$(lsb_release -sc)"/mongodb-org/3.0 main" | sudo tee /etc/apt/sources.list.d/mongodb-org-3.0.list
      

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">3</div></div>

   Reload local package database.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Issue the following command to reload the local package database:
   

   .. code-block:: sh
   
      sudo apt-get update
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 3: Reload local package database.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Issue the following command to reload the local package database:
   

   .. code-block:: sh
   
      sudo apt-get update
      

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">4</div></div>

   Install the MongoDB packages.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   You can install either the latest stable version of MongoDB or a
   specific version of MongoDB.
   

   Install the latest stable version of MongoDB.
   `````````````````````````````````````````````

   Issue the following command:

   .. code-block:: sh
   
      sudo apt-get install -y mongodb-org
      

   Install a specific release of MongoDB.
   ``````````````````````````````````````

   Specify each component package individually and append the
   version number to the package name, as in the following example:
   
   .. include:: /includes/release/pin-repo-to-version-deb.rst
   

   Pin a specific version of MongoDB.
   ``````````````````````````````````

   Although you can specify any available version of MongoDB,
   ``apt-get`` will upgrade the packages when a newer version
   becomes available. To prevent unintended upgrades, pin the
   package. To pin the version of MongoDB at the currently
   installed version, issue the following command sequence:
   

   .. code-block:: sh
   
      echo "mongodb-org hold" | sudo dpkg --set-selections
      echo "mongodb-org-server hold" | sudo dpkg --set-selections
      echo "mongodb-org-shell hold" | sudo dpkg --set-selections
      echo "mongodb-org-mongos hold" | sudo dpkg --set-selections
      echo "mongodb-org-tools hold" | sudo dpkg --set-selections
      

   Versions of the MongoDB packages before 2.6 use a different repo
   location. Refer to the version of the documentation appropriate for
   your MongoDB version.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 4: Install the MongoDB packages.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   You can install either the latest stable version of MongoDB or a
   specific version of MongoDB.
   

   Install the latest stable version of MongoDB.
   `````````````````````````````````````````````

   Issue the following command:

   .. code-block:: sh
   
      sudo apt-get install -y mongodb-org
      

   Install a specific release of MongoDB.
   ``````````````````````````````````````

   Specify each component package individually and append the
   version number to the package name, as in the following example:
   
   .. include:: /includes/release/pin-repo-to-version-deb.rst
   

   Pin a specific version of MongoDB.
   ``````````````````````````````````

   Although you can specify any available version of MongoDB,
   ``apt-get`` will upgrade the packages when a newer version
   becomes available. To prevent unintended upgrades, pin the
   package. To pin the version of MongoDB at the currently
   installed version, issue the following command sequence:
   

   .. code-block:: sh
   
      echo "mongodb-org hold" | sudo dpkg --set-selections
      echo "mongodb-org-server hold" | sudo dpkg --set-selections
      echo "mongodb-org-shell hold" | sudo dpkg --set-selections
      echo "mongodb-org-mongos hold" | sudo dpkg --set-selections
      echo "mongodb-org-tools hold" | sudo dpkg --set-selections
      

   Versions of the MongoDB packages before 2.6 use a different repo
   location. Refer to the version of the documentation appropriate for
   your MongoDB version.
   

