document index_spec;
index_spec << "cuisine" << 1 << "address.zipcode" << -1;
db["restaurants"].create_index(index_spec, {});
