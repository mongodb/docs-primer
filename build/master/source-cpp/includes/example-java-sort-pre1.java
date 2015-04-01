iterable.forEach(new Block<Document>() {
    @Override
    public void apply(final Document document) {
        System.out.println(document);
    }
});
