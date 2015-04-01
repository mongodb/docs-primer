document filter, update;
filter << "restaurant_id" << "41156888";
update << "$set" << open_document <<
           "address.street" << "East 31st Street" << close_document;

db["restaurants"].update_one(filter, update);
