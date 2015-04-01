mongocxx::pipeline stages;
document group_stage;

group_stage << "_id" << "$borough"
            << "count" << open_document
                << "$sum" << 1 << close_document;

stages.group(group_stage);

auto cursor = db["restaurants"].aggregate(stages);

for (auto&& doc : cursor) {
    std::cout << bsoncxx::to_json(doc) << std::endl;
}
