document filter, update;
filter << "name" << "Juni";
update << "$set" << open_document
           << "cuisine" << "American (New)" << close_document
       << "$currentDate" << open_document
           << "lastModified" << true << close_document;

db["restaurants"].update_one(filter, update);
