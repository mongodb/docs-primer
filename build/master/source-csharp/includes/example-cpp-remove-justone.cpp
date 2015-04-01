document filter;
filter << "borough" << "Queens";

db["restaurants"].delete_one(filter);
