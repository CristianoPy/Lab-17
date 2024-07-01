namespace Lab_17.Model
{
    class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Pictogram { get; set; }
        public List<Product> Products { get; set; } = new List<Product> ();

    }
}
