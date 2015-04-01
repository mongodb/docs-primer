.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">1</div></div>

   Configure the package management system (``yum``).
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Create a ``/etc/yum.repos.d/mongodb-org-3.0.repo`` file so that
   you can install MongoDB directly, using ``yum``.
   

   Use the following repository file to specify the *latest*
   stable release of MongoDB.
   

   .. code-block:: cfg
   
      [mongodb-org-3.0]
      name=MongoDB Repository
      baseurl=http://repo.mongodb.org/yum/redhat/$releasever/mongodb-org/3.0/x86_64/
      gpgcheck=0
      enabled=1

   Use the following repository to install *only* versions of
   MongoDB for the ``3.0`` release.  If you'd like to install
   MongoDB packages from a particular :ref:`release
   series <release-version-numbers>`, such as 2.4 or 2.6, you can
   specify the release series in the repository configuration. For
   example, to restrict your system to the 2.6 release series,
   create a ``/etc/yum.repos.d/mongodb-org-2.6.repo`` file
   to hold the following configuration information for the MongoDB
   2.6 repository:
   

   .. code-block:: cfg
   
      [mongodb-org-2.6]
      name=MongoDB 2.6 Repository
      baseurl=http://downloads-distro.mongodb.org/repo/redhat/os/x86_64/
      gpgcheck=0
      enabled=1
      

   ``.repo`` files for each release can also be found `in the repository itself <https://repo.mongodb.org/yum/{{distro_name}}/>`_.
   Remember that odd-numbered minor release versions (e.g. 2.5) are development versions and are unsuitable
   for production use.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 1: Configure the package management system (``yum``).
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Create a ``/etc/yum.repos.d/mongodb-org-3.0.repo`` file so that
   you can install MongoDB directly, using ``yum``.
   

   Use the following repository file to specify the *latest*
   stable release of MongoDB.
   

   .. code-block:: cfg
   
      [mongodb-org-3.0]
      name=MongoDB Repository
      baseurl=http://repo.mongodb.org/yum/redhat/$releasever/mongodb-org/3.0/x86_64/
      gpgcheck=0
      enabled=1

   Use the following repository to install *only* versions of
   MongoDB for the ``3.0`` release.  If you'd like to install
   MongoDB packages from a particular :ref:`release
   series <release-version-numbers>`, such as 2.4 or 2.6, you can
   specify the release series in the repository configuration. For
   example, to restrict your system to the 2.6 release series,
   create a ``/etc/yum.repos.d/mongodb-org-2.6.repo`` file
   to hold the following configuration information for the MongoDB
   2.6 repository:
   

   .. code-block:: cfg
   
      [mongodb-org-2.6]
      name=MongoDB 2.6 Repository
      baseurl=http://downloads-distro.mongodb.org/repo/redhat/os/x86_64/
      gpgcheck=0
      enabled=1
      

   ``.repo`` files for each release can also be found `in the repository itself <https://repo.mongodb.org/yum/{{distro_name}}/>`_.
   Remember that odd-numbered minor release versions (e.g. 2.5) are development versions and are unsuitable
   for production use.
   

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">2</div></div>

   Install the MongoDB packages and associated tools.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   When you install the packages, you choose whether to install the current
   release or a previous one. This step provides the commands for both.
   

   To install the latest stable version of MongoDB, issue the following
   command:
   

   .. code-block:: sh
   
      sudo yum install -y mongodb-org
      

   To install a specific release of MongoDB, specify each
   component package individually and append the version number to the
   package name, as in the following example:
   
   .. include:: /includes/release/pin-repo-to-version-yum.rst
   

   You can specify any available version of MongoDB. However ``yum``
   will upgrade the packages when a newer version becomes available. To
   prevent unintended upgrades, pin the package. To pin a package, add
   the following ``exclude`` directive to your ``/etc/yum.conf`` file:
   

   .. code-block:: ini
   
      exclude=mongodb-org,mongodb-org-server,mongodb-org-shell,mongodb-org-mongos,mongodb-org-tools
      

   Versions of the MongoDB packages before 2.6 use a different repo
   location. Refer to the version of the documentation appropriate for
   your MongoDB version.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 2: Install the MongoDB packages and associated tools.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   When you install the packages, you choose whether to install the current
   release or a previous one. This step provides the commands for both.
   

   To install the latest stable version of MongoDB, issue the following
   command:
   

   .. code-block:: sh
   
      sudo yum install -y mongodb-org
      

   To install a specific release of MongoDB, specify each
   component package individually and append the version number to the
   package name, as in the following example:
   
   .. include:: /includes/release/pin-repo-to-version-yum.rst
   

   You can specify any available version of MongoDB. However ``yum``
   will upgrade the packages when a newer version becomes available. To
   prevent unintended upgrades, pin the package. To pin a package, add
   the following ``exclude`` directive to your ``/etc/yum.conf`` file:
   

   .. code-block:: ini
   
      exclude=mongodb-org,mongodb-org-server,mongodb-org-shell,mongodb-org-mongos,mongodb-org-tools
      

   Versions of the MongoDB packages before 2.6 use a different repo
   location. Refer to the version of the documentation appropriate for
   your MongoDB version.
   

