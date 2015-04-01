document filter, replacement;
filter << "restaurant_id" << "41704620";
replacement << "name" << "Vella 2"
            << "address" << open_document
                << "coord" << open_array
                    << -73.9557413 << 40.7720266 << close_array
                << "building" << "1480"
                << "street" << "2 Avenue"
                << "zipcode" << "10075" << close_document;

db["restaurants"].replace_one(filter, replacement);
