mongocxx::pipeline stages;
document match_stage, group_stage;

match_stage << "borough" << "Queens"
            << "cuisine" << "Brazilian";

group_stage << "_id" << "$address.zipcode"
            << "count" << open_document
                << "$sum" << 1 << close_document;

stages.match(match_stage).group(group_stage);

auto cursor = db["restaurants"].aggregate(stages);

for (auto&& doc : cursor) {
    std::cout << bsoncxx::to_json(doc) << std::endl;
}
