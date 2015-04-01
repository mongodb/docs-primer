document filter;
filter << "borough" << "Manhattan";

db["restaurants"].delete_many(filter);
