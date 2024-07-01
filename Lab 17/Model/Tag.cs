namespace Lab_17.Model
{
    class Tag
    {
        public Guid Id { get; set; }
        public Guid BarCode { get; set; } = Guid.NewGuid();
        public double Price { get; set; }
        public Product Products { get; set; }

    }
}
