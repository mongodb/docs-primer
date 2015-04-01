auto cursor = db["restaurants"]
    .find(document{} << "borough" << "Manhattan" << finalize);

for (auto&& doc : cursor) {
    std::cout << bsoncxx::to_json(doc) << std::endl;
}
