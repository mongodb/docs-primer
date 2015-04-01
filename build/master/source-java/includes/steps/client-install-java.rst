.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">1</div></div>

   Download the MongoDB Java Driver and the BSON library.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   From the
   `Java Driver Installation Page <http://mongodb.github.io/mongo-java-driver/current/getting-started/installation-guide/>`_,
   follow the instructions to
   `install the MongoDB Java Driver <http://mongodb.github.io/mongo-java-driver/current/getting-started/installation-guide/#mongodb-driver:9d4f5debee078ff2736b8039cc26277c>`_
   as well as to `install the BSON library <http://mongodb.github.io/mongo-java-driver/current/getting-started/installation-guide/#bson:9d4f5debee078ff2736b8039cc26277c>`_.
   The page provides details to install via a dependency management
   system or to download the jars directly from The Central Repository.
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 1: Download the MongoDB Java Driver and the BSON library.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

   From the
   `Java Driver Installation Page <http://mongodb.github.io/mongo-java-driver/current/getting-started/installation-guide/>`_,
   follow the instructions to
   `install the MongoDB Java Driver <http://mongodb.github.io/mongo-java-driver/current/getting-started/installation-guide/#mongodb-driver:9d4f5debee078ff2736b8039cc26277c>`_
   as well as to `install the BSON library <http://mongodb.github.io/mongo-java-driver/current/getting-started/installation-guide/#bson:9d4f5debee078ff2736b8039cc26277c>`_.
   The page provides details to install via a dependency management
   system or to download the jars directly from The Central Repository.
   

.. only:: html or dirhtml or singlehtml

   .. raw:: html
   
      <div class="sequence-block"><div class="bullet-block"><div class="sequence-step">2</div></div>

   Connect to MongoDB.
   ~~~~~~~~~~~~~~~~~~~

   Use com.mongodb.MongoClient_ class to connect to a running
   :program:`mongod` instance. Access a specific database in MongoDB
   using the com.mongodb.client.MongoDatabase_ interface.
   

   Include the following ``import`` statements.
   

   .. code-block:: javascript
   
      import com.mongodb.MongoClient;
      import com.mongodb.client.MongoDatabase;
      

   Connect to a MongoDB instance running on the ``localhost`` on the
   default port ``27017``:
   

   .. code-block:: java
   
      MongoClient mongoClient = new MongoClient();
      

   To specify a different host and port, see the com.mongodb.MongoClient_ API page.
   

   Once successfully connected, access the ``test`` database:
   

   .. code-block:: java
   
      MongoDatabase db = mongoClient.getDatabase("test");
      

   .. _com.mongodb.MongoClient: http://api.mongodb.org/java/3.0/com/mongodb/MongoClient.html
   .. _com.mongodb.client.MongoDatabase: http://api.mongodb.org/java/3.0/com/mongodb/client/MongoDatabase.html
   

   .. raw:: html
   
      </div>

.. only:: latex or epub

   Step 2: Connect to MongoDB.
   ~~~~~~~~~~~~~~~~~~~~~~~~~~~

   Use com.mongodb.MongoClient_ class to connect to a running
   :program:`mongod` instance. Access a specific database in MongoDB
   using the com.mongodb.client.MongoDatabase_ interface.
   

   Include the following ``import`` statements.
   

   .. code-block:: javascript
   
      import com.mongodb.MongoClient;
      import com.mongodb.client.MongoDatabase;
      

   Connect to a MongoDB instance running on the ``localhost`` on the
   default port ``27017``:
   

   .. code-block:: java
   
      MongoClient mongoClient = new MongoClient();
      

   To specify a different host and port, see the com.mongodb.MongoClient_ API page.
   

   Once successfully connected, access the ``test`` database:
   

   .. code-block:: java
   
      MongoDatabase db = mongoClient.getDatabase("test");
      

   .. _com.mongodb.MongoClient: http://api.mongodb.org/java/3.0/com/mongodb/MongoClient.html
   .. _com.mongodb.client.MongoDatabase: http://api.mongodb.org/java/3.0/com/mongodb/client/MongoDatabase.html
   

