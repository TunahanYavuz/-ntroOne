Product product1 = new Product();

product1.productsname = "HP Victus";
product1.productsprice = 30000;
product1.productspercentage = 3;
 
Product product2 = new Product();

product2.productsname = "MSI Pulse";
product2.productsprice = 57268;
product2.productspercentage = 0;

Console.WriteLine(product1.productsname);

Product[] products = new Product[] {product1 , product2 };
foreach (var prod in products)
{
    Console.WriteLine(prod.productsname+" "+prod.productsprice+" "+prod.productspercentage);
}
class Product
{
    public string productsname { get; set; }
    public int productsprice { get; set; }
    public float productspercentage { get; set; }
}
