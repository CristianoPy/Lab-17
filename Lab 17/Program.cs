
using Lab_17.Model;

//Seed();
using var ctx = new ShopDbContext();
static void Seed()
{
    using var ctx = new ShopDbContext();


    var ferrari = new Productor
    {
        Name = "Ferrari",
        Adress = "Italy",
        CUI = Guid.NewGuid().ToString()

    };

    ctx.Add(ferrari);

    var F50 = new Product
    {
        Name = "F50",
        Productor = ferrari,
        Stock = 5
    };

    ctx.Add(F50);

    var Tag = new Tag
    {
        Products = F50,
        Price = 500.000

    };

    ctx.Add(Tag);

    var car = new Category
    {
        Name = "Car",
        Pictogram = "ferrari.com"
    };

    ctx.Add(car);

    ctx.SaveChanges();

}
