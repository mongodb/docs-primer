.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">1</div></div>

   Download the MongoDB C++ Driver.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Download the driver from
   `<http://www.nuget.org/packages/mongocsharpdriver/>`_.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 1: Download the MongoDB C++ Driver.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Download the driver from
   `<http://www.nuget.org/packages/mongocsharpdriver/>`_.
   

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">2</div></div>

   Add Reference to C# Driver DLLs.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Add to your project references to the following DLLs:
   
   #. ``MongoDB.Bson.dll``
   #. ``MongoDB.Driver.dll``
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 2: Add Reference to C# Driver DLLs.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Add to your project references to the following DLLs:
   
   #. ``MongoDB.Bson.dll``
   #. ``MongoDB.Driver.dll``
   

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">3</div></div>

   Connect to MongoDB.
   ~~~~~~~~~~~~~~~~~~~

   Use MongoClient_  to connect to a running
   :program:`mongod` instance.
   

   Add the following ``using`` statements in your C# program.
   

   .. code-block:: csharp
   
      using MongoDB.Bson;
      using MongoDB.Driver;
      

   Include the following code in your program to create a client
   connection to a running :program:`mongod` instance and use the
   ``test`` database.
   

   .. code-block:: csharp
   
      protected static IMongoClient _client;
      protected static IMongoDatabase _database;
      
      _client = new MongoClient();
      _database = _client.GetDatabase("test");
      

   To specify a different host and port for the :program:`mongod` instance, see
   the MongoClient_ API page.
   
   .. _MongoClient: http://api.mongodb.org/csharp/2.0.0/html/70ea37fb-6258-c51a-db65-d3b6e255f36e.htm
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 3: Connect to MongoDB.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Use MongoClient_  to connect to a running
   :program:`mongod` instance.
   

   Add the following ``using`` statements in your C# program.
   

   .. code-block:: csharp
   
      using MongoDB.Bson;
      using MongoDB.Driver;
      

   Include the following code in your program to create a client
   connection to a running :program:`mongod` instance and use the
   ``test`` database.
   

   .. code-block:: csharp
   
      protected static IMongoClient _client;
      protected static IMongoDatabase _database;
      
      _client = new MongoClient();
      _database = _client.GetDatabase("test");
      

   To specify a different host and port for the :program:`mongod` instance, see
   the MongoClient_ API page.
   
   .. _MongoClient: http://api.mongodb.org/csharp/2.0.0/html/70ea37fb-6258-c51a-db65-d3b6e255f36e.htm
   

