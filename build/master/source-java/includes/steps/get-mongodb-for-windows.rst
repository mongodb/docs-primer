.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">1</div></div>

   Determine which MongoDB build you need.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   There are three builds of MongoDB for Windows:
   
   **MongoDB for Windows 64-bit** runs only
   on Windows Server 2008 R2, Windows 7 64-bit, and newer versions of
   Windows. This build takes advantage of recent enhancements to the
   Windows Platform and cannot operate on older versions of Windows.
   
   **MongoDB for Windows 32-bit** runs on any 32-bit version of Windows
   newer than Windows Vista. 32-bit versions of MongoDB are only intended for
   older systems and for use in testing and development systems. 32-bit
   versions of MongoDB only support databases smaller than 2GB.
   
   **MongoDB for Windows 64-bit Legacy** runs on Windows Vista, Windows
   Server 2003, and Windows Server 2008 and does not include recent
   performance enhancements.
   

   To find which version of Windows you are running, enter the following
   commands in the :guilabel:`Command Prompt` or :guilabel:`Powershell`:
   

   .. code-block:: powershell
   
      wmic os get caption
      wmic os get osarchitecture
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 1: Determine which MongoDB build you need.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   There are three builds of MongoDB for Windows:
   
   **MongoDB for Windows 64-bit** runs only
   on Windows Server 2008 R2, Windows 7 64-bit, and newer versions of
   Windows. This build takes advantage of recent enhancements to the
   Windows Platform and cannot operate on older versions of Windows.
   
   **MongoDB for Windows 32-bit** runs on any 32-bit version of Windows
   newer than Windows Vista. 32-bit versions of MongoDB are only intended for
   older systems and for use in testing and development systems. 32-bit
   versions of MongoDB only support databases smaller than 2GB.
   
   **MongoDB for Windows 64-bit Legacy** runs on Windows Vista, Windows
   Server 2003, and Windows Server 2008 and does not include recent
   performance enhancements.
   

   To find which version of Windows you are running, enter the following
   commands in the :guilabel:`Command Prompt` or :guilabel:`Powershell`:
   

   .. code-block:: powershell
   
      wmic os get caption
      wmic os get osarchitecture
      

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">2</div></div>

   Download MongoDB for Windows.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Download the latest production release of MongoDB from the `MongoDB
   downloads page <http://www.mongodb.org/downloads>`_. Ensure you download
   the correct version of MongoDB for your Windows system. The 64-bit
   versions of MongoDB does not work with 32-bit Windows.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 2: Download MongoDB for Windows.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Download the latest production release of MongoDB from the `MongoDB
   downloads page <http://www.mongodb.org/downloads>`_. Ensure you download
   the correct version of MongoDB for your Windows system. The 64-bit
   versions of MongoDB does not work with 32-bit Windows.
   

