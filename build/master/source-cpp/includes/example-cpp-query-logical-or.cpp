document filter;
filter << "$or" << open_array
           << open_document
               << "cuisine" << "Italian" << close_document
           << open_document
              << "address.zipcode" << "10075" << close_document
       << close_array;

auto cursor = db["restaurants"].find(filter);
for (auto&& doc : cursor) {
    std::cout << bsoncxx::to_json(doc) << std::endl;
}
