.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">1</div></div>

   Install Node.js and ``npm``
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~

   OS X/Windows
   ````````````

   Download the installer from `<http://nodejs.org/download/>`_ and
   run to install Node.js and ``npm``.
   

   Other supported platforms
   `````````````````````````

   Download the Node.js and ``npm`` binaries from `<http://nodejs.org/download/>`_.

   Ensure the installed Node.js and ``npm`` are in the appropriate path.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 1: Install Node.js and ``npm``
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   OS X/Windows
   ````````````

   Download the installer from `<http://nodejs.org/download/>`_ and
   run to install Node.js and ``npm``.
   

   Other supported platforms
   `````````````````````````

   Download the Node.js and ``npm`` binaries from `<http://nodejs.org/download/>`_.

   Ensure the installed Node.js and ``npm`` are in the appropriate path.
   

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">2</div></div>

   Install MongoDB Node.js Driver
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Use ``npm`` to install the MongoDB Node.js driver.
   

   .. code-block:: sh
   
      npm install mongodb
      

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 2: Install MongoDB Node.js Driver
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Use ``npm`` to install the MongoDB Node.js driver.
   

   .. code-block:: sh
   
      npm install mongodb
      

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">3</div></div>

   Declare MongoClient variable and other variables.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Complete the remainder of this procedure in a ``node`` interactive
   shell or other environment (e.g. script).
   

   .. code-block:: javascript
   
      var MongoClient = require('mongodb').MongoClient;
      var assert = require('assert');
      

   Connect using the ``MongoClient`` to a running
   :program:`mongod` instance by specifying the :manual:`MongoDB uri
   </reference/connection-string>`. For example, the following code
   connects to a MongoDB instance that runs on the ``localhost``
   interface on port ``27017`` and switch to the ``test`` database.
   

   .. code-block:: javascript
   
      var url = 'mongodb://localhost:27017/test';
      MongoClient.connect(url, function(err, db) {
        assert.equal(null, err);
        console.log("Connected correctly to server.");
        db.close();
      });
      

   A successful connection should print out the following line:
   

   .. code-block:: sh
   
      Connected correctly to server.
      

   Otherwise, the code throws an assertion.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 3: Declare MongoClient variable and other variables.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Complete the remainder of this procedure in a ``node`` interactive
   shell or other environment (e.g. script).
   

   .. code-block:: javascript
   
      var MongoClient = require('mongodb').MongoClient;
      var assert = require('assert');
      

   Connect using the ``MongoClient`` to a running
   :program:`mongod` instance by specifying the :manual:`MongoDB uri
   </reference/connection-string>`. For example, the following code
   connects to a MongoDB instance that runs on the ``localhost``
   interface on port ``27017`` and switch to the ``test`` database.
   

   .. code-block:: javascript
   
      var url = 'mongodb://localhost:27017/test';
      MongoClient.connect(url, function(err, db) {
        assert.equal(null, err);
        console.log("Connected correctly to server.");
        db.close();
      });
      

   A successful connection should print out the following line:
   

   .. code-block:: sh
   
      Connected correctly to server.
      

   Otherwise, the code throws an assertion.
   

