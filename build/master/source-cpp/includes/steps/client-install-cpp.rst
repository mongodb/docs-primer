.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">1</div></div>

   Download the MongoDB C++ Driver
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Download the source from
   `<https://github.com/mongodb/mongo-cxx-driver>`_.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 1: Download the MongoDB C++ Driver
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Download the source from
   `<https://github.com/mongodb/mongo-cxx-driver>`_.
   

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">2</div></div>

   Compile the Driver
   ~~~~~~~~~~~~~~~~~~

   To compile, follow the build instructions on
   `<https://github.com/mongodb/mongo-cxx-driver/wiki/Quickstart-Guide-(New-Driver)>`_.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 2: Compile the Driver
   ~~~~~~~~~~~~~~~~~~~~~~~~~~

   To compile, follow the build instructions on
   `<https://github.com/mongodb/mongo-cxx-driver/wiki/Quickstart-Guide-(New-Driver)>`_.
   

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">3</div></div>

   Connect to MongoDB
   ~~~~~~~~~~~~~~~~~~

   Use ``mongocxx::client`` class to connect to a running
   :program:`mongod` instance.
   
   Add the following code in your C++ program.
   

   Add the following ``#include`` statements.
   

   .. code-block:: javascript
   
      #include <mongocxx/client.hpp>
      #include <mongocxx/instance.hpp>
      

   .. include:: includes/extracts/cpp-connect.rst
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 3: Connect to MongoDB
   ~~~~~~~~~~~~~~~~~~~~~~~~~~

   Use ``mongocxx::client`` class to connect to a running
   :program:`mongod` instance.
   
   Add the following code in your C++ program.
   

   Add the following ``#include`` statements.
   

   .. code-block:: javascript
   
      #include <mongocxx/client.hpp>
      #include <mongocxx/instance.hpp>
      

   .. include:: includes/extracts/cpp-connect.rst
   

