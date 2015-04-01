mongocxx::options::find opts;
document ordering;
ordering << "borough" << 1
         << "address.zipcode" << -1;
opts.sort(ordering);

auto cursor = db["restaurants"].find({}, opts);
for (auto&& doc : cursor) {
    std::cout << bsoncxx::to_json(doc) << std::endl;
}
