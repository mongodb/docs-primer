auto restaurant_doc = document{}
    << "address" << open_document
        << "street"   << "2 Avenue"
        << "zipcode"  <<  "10075"
        << "building" << "1480"
        << "coord"    << open_array
            << -73.9557413 << 40.7720266 << close_array << close_document
    << "borough"  << "Manhattan"
    << "cuisine"  << "Italian"
    << "grades"   << open_array
        << open_document
            << "date" << bsoncxx::types::b_date{12323}
            << "grade" << "A"
            << "score" << 11 << close_document
        << open_document
            << "date" << bsoncxx::types::b_date{121212}
            << "grade" << "B"
            << "score" << 17 << close_document << close_array
    << "name" << "Vella"
    << "restaurant_id" << "41704620" << finalize;
auto res = db["restaurants"].insert_one(restaurant_doc);
