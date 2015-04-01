document filter;
filter << "cuisine" << "Italian"
       << "address.zipcode" << "10075";

auto cursor = db["restaurants"].find(filter);
for (auto&& doc : cursor) {
    std::cout << bsoncxx::to_json(doc) << std::endl;
}
