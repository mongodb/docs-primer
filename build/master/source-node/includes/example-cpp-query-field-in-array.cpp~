document filter;
filter << "grades.grade" << "B";

auto cursor = db["restaurants"].find(filter);
for (auto&& doc : cursor) {
    std::cout << bsoncxx::to_json(doc) << std::endl;
}
