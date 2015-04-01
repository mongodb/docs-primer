document filter;
filter << "grades.score" << open_document
           << "$lt" << 10 << close_document;

auto cursor = db["restaurants"].find(filter);
for (auto&& doc : cursor) {
    std::cout << bsoncxx::to_json(doc) << std::endl;
}
