document filter, update;
filter << "address.zipcode" << "10016"
       << "cuisine" << "Other";
update << "$set" << open_document
           << "cuisine" << "Category To Be Determined" << close_document
       << "$currentDate" << open_document
           << "lastModified" << true << close_document;

db["restaurants"].update_many(filter, update);
