In the C++ Driver documentation, see delete_one_, delete_many_ and drop_.

In MongoDB, write operations are atomic on the level of a single
document. If a single remove operation removes multiple documents from
a collection, the operation can interleave with other write operations
on that collection. In the MongoDB Manual, see
:manual:`Atomicity </core/write-operations-atomicity>`.

