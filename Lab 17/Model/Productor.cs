namespace Lab_17.Model
{
    class Productor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string CUI { get; set; }
        public List<Product> Products { get; set;} = new List<Product>();

    }
}
