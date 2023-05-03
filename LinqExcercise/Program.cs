namespace LinqExcercise
{
    //Create a model class with name Product
    class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }

    internal class Program
    {
        //create an instance of List collection class of type Product.
        List<Product> products;
        //Create a method with name SeedData inside program class and populate the list with some initial data.
        public void seeddata()
        {
            products = new List<Product>()
            {
                new Product {ProductId = "P001", ProductName = "Laptop", Brand = "Dell", Quantity = 5, Price = 35000},
                new Product {ProductId = "P002", ProductName = "Camera", Brand = "Canon", Quantity = 8, Price = 28500},
                new Product {ProductId = "P003", ProductName = "Tablet", Brand = "Lenovo", Quantity = 4, Price = 15000},
                new Product {ProductId = "P004", ProductName = "Mobile", Brand = "Apple", Quantity = 9, Price = 65000},
                new Product {ProductId = "P005", ProductName = "Earphones", Brand = "Boat", Quantity = 2, Price = 1500}

            };
            //To retrieve the Product names from Product List where Price is between 20000 to 40000.
            Console.WriteLine("(1)-Product names from Product List where Price is between 20000 to 40000.");
            var query1 = products.Where(x => x.Price > 20000 && x.Price < 40000);
            foreach (Product x in query1)
            {
                Console.WriteLine($"{x.ProductName}");

            }
            Console.WriteLine();
            //For retrieving the data from Product List where ProductName contains letter'a'.
            Console.WriteLine("(2)-Product List where ProductName contains letter 'a':");
            var query2 = products.Where(x => x.ProductName.Contains('a'));
            foreach (Product x in query2)
            {
                Console.WriteLine($" {x.ProductName}");

            }
            Console.WriteLine();
            //For retrieving all data from Product List arranged in alphabetical order based on ProductName.
            Console.WriteLine("(3)-Product List arranged in alphabetical order based on ProductName : ");
            var query3 = from x in products orderby x.ProductName select x;
            foreach (Product x in query3)
            {
                Console.WriteLine($"{x.ProductId} {x.ProductName} {x.Brand} {x.Quantity} {x.Price}");

            }
            Console.WriteLine();
            //For retrieving the highest Price from Product List.
            Console.WriteLine("(4)-The Highest Price from Product List : ");
            var query4 = products.Where(x => x.Price == products.Max(x => x.Price)).ToList();
            foreach (Product x in query4)
            {
                Console.WriteLine($"{x.ProductId} {x.ProductName} {x.Brand} {x.Quantity} {x.Price}");
            }
            Console.WriteLine();
            //To check whether the Product with ProductId P003 exists in Product List or not. The output should be a Boolean value.
            Console.WriteLine("(5)-Check whether the Product with ProductId P003 exists in Product List or not");
            var query5 = products.Any(x => x.ProductId == "P003");
            Console.WriteLine(query5);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Call the SeedData method in main
            Program p = new Program();
            p.seeddata();
        }
    }
}