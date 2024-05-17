namespace ShoppingAppAPI.Models
{
    public class ProductRepository
    {
        private List<Product> products = new List<Product>
        {
            new Product {Id=1, ImageUrl="samsung.jpg", Name="Samsung Galaxy s24 ultra", Price=118000, Description="Samsung Galaxy S24 Ultra 5G AI Smartphone (Titanium Gray, 12GB, 256GB Storage)"},
            new Product {Id=2, ImageUrl="iphone.jpg", Name="Apple Iphone 15 Pro Max", Price=150000, Description="Apple iPhone 15 Pro Max (256 GB) - Black Titanium"},
            new Product {Id=3, ImageUrl="refrigerator.jpg", Name="Samsung Refrigerator", Price=25000, Description="Samsung 183 L, 5 Star, Digital Inverter, Direct-Cool Single Door Refrigerator (RR20D2825HV/NL, Himalaya Poppy Blue, Base Stand Drawer, 2024 Model)"},
            new Product {Id=4, ImageUrl="washing_machine.jpg", Name="LG Washing Machine", Price=20000, Description="LG 7 Kg 5 Star Inverter Touch panel Fully-Automatic Front Load Washing Machine with In-Built Heater (FHM1207SDM, Middle Black, Steam for Hygiene Wash)"}
        };

        public List<Product> GetAllProducts()
        {
            return products;
        }
        public List<Product> GetProducts(string searchQuery = "")
        {
            if (string.IsNullOrEmpty(searchQuery))
            {
                return products;
            }
            else
            {
                return products.Where(p => p.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
            }           
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}
