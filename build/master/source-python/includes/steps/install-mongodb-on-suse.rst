.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">1</div></div>

   Configure the package management system (``zypper``).
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Add the repository so that you can install MongoDB using ``zypper``.
   

   Use the following command to specify the *latest* stable release of MongoDB.
   

   .. code-block:: sh
   
      zypper addrepo --no-gpgcheck http://repo.mongodb.org/zypper/suse/11/mongodb-org/3.0/x86_64/ mongodb
      

   This repository only offers the ``3.0`` MongoDB release.  If you'd like
   to install MongoDB packages from a previous :ref:`release
   series <release-version-numbers>`, such as 2.6, you can
   specify the release series in the repository configuration. For
   example, to restrict your system to the 2.6 release series,
   use the following command:
   

   .. code-block:: sh
   
      zypper addrepo --no-gpgcheck http://downloads-distro.mongodb.org/repo/suse/os/x86_64/ mongodb
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 1: Configure the package management system (``zypper``).
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Add the repository so that you can install MongoDB using ``zypper``.
   

   Use the following command to specify the *latest* stable release of MongoDB.
   

   .. code-block:: sh
   
      zypper addrepo --no-gpgcheck http://repo.mongodb.org/zypper/suse/11/mongodb-org/3.0/x86_64/ mongodb
      

   This repository only offers the ``3.0`` MongoDB release.  If you'd like
   to install MongoDB packages from a previous :ref:`release
   series <release-version-numbers>`, such as 2.6, you can
   specify the release series in the repository configuration. For
   example, to restrict your system to the 2.6 release series,
   use the following command:
   

   .. code-block:: sh
   
      zypper addrepo --no-gpgcheck http://downloads-distro.mongodb.org/repo/suse/os/x86_64/ mongodb
      

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
   
      sudo zypper install mongodb-org
      

   To install a specific release of MongoDB, specify each
   component package individually and append the version number to the
   package name, as in the following example:
   
   .. include:: /includes/release/pin-repo-suse.rst
   

   You can specify any available version of MongoDB. However ``zypper``
   will upgrade the packages when a newer version becomes available. To
   prevent unintended upgrades, pin the packages by running the following
   command:
   
   .. include:: /includes/release/pin-repo-suse-lock.rst
   

   Previous versions of MongoDB packages use a different repository location.
   Refer to the version of the documentation appropriate for
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
   
      sudo zypper install mongodb-org
      

   To install a specific release of MongoDB, specify each
   component package individually and append the version number to the
   package name, as in the following example:
   
   .. include:: /includes/release/pin-repo-suse.rst
   

   You can specify any available version of MongoDB. However ``zypper``
   will upgrade the packages when a newer version becomes available. To
   prevent unintended upgrades, pin the packages by running the following
   command:
   
   .. include:: /includes/release/pin-repo-suse-lock.rst
   

   Previous versions of MongoDB packages use a different repository location.
   Refer to the version of the documentation appropriate for
   your MongoDB version.
   

